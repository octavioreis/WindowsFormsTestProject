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
        private readonly SaveController _saveController;
        private readonly FuelCollectionManager _fuelCollectionManager;
        private readonly TankCollectionManager _tankCollectionManager;
        private readonly NozzleCollectionManager _nozzleCollectionManager;
        private AbstractCollectionManager _currentCollectionManager;

        public ItemsController(IItemsView view, IDatabase database, INavigator navigator)
        {
            _view = view;

            view.SetController(this);

            _saveController = new SaveController(view.GetSaveView(), database, navigator, ModelChanged);
        }

        public void AddItem()
        {
            var newItem = _currentCollectionManager.AddItem();

            _view.AddItem(newItem);
            _view.SelectItem(newItem);
        }

        public void LoadItems(RegistryType registryType)
        {
            _saveController.SetCurrentController(registryType);
            SetCurrentCollectionManager(registryType);

            LoadItems(_currentCollectionManager.GetItems());
        }

        public void RemoveItem(IdentifiedRegistry identifiedRegistry)
        {
            if (_currentCollectionManager.TryRemoveItem(identifiedRegistry, out string errorMessage))
                _view.RemoveItem(identifiedRegistry);
            else
                _view.ShowWarningMessage(errorMessage);
        }

        public void SelectItem(Guid id)
        {
            _view.SelectItem(id);
        }

        public void UpdateRegistryViewItem(IdentifiedRegistry identifiedRegistry)
        {
            _saveController.UpdateViewItem(identifiedRegistry);
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
