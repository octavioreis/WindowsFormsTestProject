using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class ItemsController
    {
        private readonly IItemsView _view;
        private readonly FuelController _fuelController;
        private readonly TankController _tankController;
        private readonly NozzleController _nozzleController;
        private AbstractRegistryController _currentController;

        public ItemsController(IItemsView view, IDatabase database, INavigator navigator)
        {
            _view = view;

            view.SetController(this);

            _fuelController = new FuelController(view.GetFuelView(), database);
            _tankController = new TankController(view.GetTankView(), database, navigator);
            _nozzleController = new NozzleController(view.GetNozzleView(), database, navigator);

            _fuelController.ModelChanged += ModelChanged;
            _tankController.ModelChanged += ModelChanged;
            _nozzleController.ModelChanged += ModelChanged;
        }

        public void AddItem()
        {
            var newItem = _currentController.AddItem();

            _view.AddItem(newItem);
            _view.SelectItem(newItem);
        }

        public void LoadItems(RegistryType registryType)
        {
            switch (registryType)
            {
                case RegistryType.Fuel:
                    UpdateViewsVisibility(true, false, false);
                    _currentController = _fuelController;
                    break;
                case RegistryType.Tank:
                    UpdateViewsVisibility(false, true, false);
                    _currentController = _tankController;
                    break;
                case RegistryType.Nozzle:
                    UpdateViewsVisibility(false, false, true);
                    _currentController = _nozzleController;
                    break;
                default:
                    UpdateViewsVisibility(false, false, false);
                    _currentController = null;
                    break;
            }

            LoadItems(_currentController?.GetItems());
        }

        public void RemoveItem(IdentifiedRegistry identifiedRegistry)
        {
            if (_currentController.TryRemoveItem(identifiedRegistry, out string errorMessage))
                _view.RemoveItem(identifiedRegistry);
            else
                _view.ShowErrorMessage(errorMessage);
        }

        public void SelectItem(Guid id)
        {
            _view.SelectItem(id);
        }

        public void UpdateRegistryViewInformation(IdentifiedRegistry identifiedRegistry)
        {
            if (identifiedRegistry == null)
            {
                _currentController.SetViewVisibility(false);
                return;
            }
            else
                _currentController.SetViewVisibility(true);

            _currentController.SetSelectedItem(identifiedRegistry);
        }

        private void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            if (items == null)
                return;

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }

        private void UpdateViewsVisibility(bool fuelVisible, bool tankVisible, bool nozzleVisible)
        {
            _fuelController.SetViewVisibility(fuelVisible);
            _tankController.SetViewVisibility(tankVisible);
            _nozzleController.SetViewVisibility(nozzleVisible);
        }

        private void ModelChanged(object sender, EventArgs e)
        {
            _view.UpdateSelectedItem();
        }
    }
}
