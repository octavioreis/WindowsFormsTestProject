using System;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class RegistryHostController
    {
        private readonly IRegistryHostView _view;
        private readonly FuelController _fuelController;
        private readonly TankController _tankController;
        private readonly NozzleController _nozzleController;
        private AbstractRegistryController _currentController;

        public RegistryHostController(IRegistryHostView view, IDatabase database, INavigator navigator, EventHandler modelChanged)
        {
            _view = view;

            view.SetController(this);

            _fuelController = new FuelController(view.GetFuelView(), database);
            _tankController = new TankController(view.GetTankView(), database, navigator);
            _nozzleController = new NozzleController(view.GetNozzleView(), database, navigator);

            _fuelController.ModelChanged += modelChanged;
            _tankController.ModelChanged += modelChanged;
            _nozzleController.ModelChanged += modelChanged;
        }

        public void SetCurrentController(RegistryType registryType)
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
            }

            _view.SetSaveButtonTooltip(_currentController.GetSaveButtonTooltip());
        }

        public bool TryUpdateModel(out string message)
        {
            return _currentController.TryUpdateModel(out message);
        }

        public void UpdateViewItem(IdentifiedRegistry identifiedRegistry)
        {
            if (identifiedRegistry == null)
            {
                _currentController.SetViewVisibility(false);
                return;
            }

            _currentController.SetViewVisibility(true);
            _currentController.UpdateViewItem(identifiedRegistry);
        }

        private void UpdateViewsVisibility(bool fuelVisible, bool tankVisible, bool nozzleVisible)
        {
            _fuelController.SetViewVisibility(fuelVisible);
            _tankController.SetViewVisibility(tankVisible);
            _nozzleController.SetViewVisibility(nozzleVisible);
        }
    }
}
