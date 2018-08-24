using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Controller.CollectionManagers;
using TestProject.Database;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class ItemsController
    {
        private readonly IItemsView _view;
        private readonly RegistryHostController _hostController;
        private readonly FuelCollectionManager _fuelCollectionManager;
        private readonly TankCollectionManager _tankCollectionManager;
        private readonly NozzleCollectionManager _nozzleCollectionManager;
        private AbstractCollectionManager _currentCollectionManager;

        public ItemsController(IItemsView view, IDatabase database, INavigator navigator)
        {
            _view = view;

            view.SetController(this);

            _hostController = new RegistryHostController(view.GetRegistryHostView(), database, navigator, ModelChanged);

            _fuelCollectionManager = new FuelCollectionManager(database);
            _tankCollectionManager = new TankCollectionManager(database);
            _nozzleCollectionManager = new NozzleCollectionManager(database);
        }

        public void AddItem()
        {
            var newItem = _currentCollectionManager.AddItem();

            _view.AddItem(newItem);
            _view.SelectItem(newItem);
        }

        public void LoadItems(RegistryType registryType)
        {
            _hostController.SetCurrentController(registryType);
            SetCurrentCollectionManager(registryType);

            LoadItems(_currentCollectionManager.GetItems());
        }

        public bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            if (_currentCollectionManager.TryRemoveItem(identifiedRegistry, out message))
            {
                _view.RemoveItem(identifiedRegistry);
                return true;
            }

            return false;
        }

        public void SelectItem(Guid id)
        {
            _view.SelectItem(id);
        }

        public void UpdateRegistryViewItem(IdentifiedRegistry identifiedRegistry)
        {
            _hostController.UpdateViewItem(identifiedRegistry);
        }

        private void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }

        private void SetCurrentCollectionManager(RegistryType registryType)
        {
            switch (registryType)
            {
                case RegistryType.Fuel:
                    _currentCollectionManager = _fuelCollectionManager;
                    break;

                case RegistryType.Tank:
                    _currentCollectionManager = _tankCollectionManager;
                    break;

                case RegistryType.Nozzle:
                    _currentCollectionManager = _nozzleCollectionManager;
                    break;
            }
        }

        private void ModelChanged(object sender, EventArgs e)
        {
            _view.UpdateSelectedItem();
        }
    }
}
