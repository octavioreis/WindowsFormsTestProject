using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class TankController : AbstractRegistryController
    {
        private readonly ITankView _view;
        private readonly IDatabase _database;
        private readonly INavigator _navigator;
        private Tank _tank;
        private IEnumerable<Fuel> _fuels;

        public TankController(ITankView view, IDatabase database, INavigator navigator) : base(view)
        {
            _view = view;
            _database = database;
            _navigator = navigator;

            view.SetController(this);
        }

        #region AbstractRegistryController Members

        public override string GetSaveButtonTooltip()
        {
            return "Salvar alterações no tanque (Ctrl+S)";
        }

        public override void UpdateViewItem(IdentifiedRegistry identifiedRegistry)
        {
            _tank = identifiedRegistry as Tank;
            UpdateView();
        }

        public override void SetViewVisibility(bool visible)
        {
            if (visible)
            {
                _fuels = _database.GetFuels();
                _view.SetFuelOptions(_fuels);
            }

            base.SetViewVisibility(visible);
        }

        public override void UpdateView()
        {
            _view.TankName = _tank.Name;
            _view.StorageCapacity = _tank.StorageCapacity;
            _view.Fuel = _fuels.FirstOrDefault(f => f.Id == _tank.FuelId);
        }

        protected sealed override void UpdateModel()
        {
            _tank.Name = _view.TankName;
            _tank.StorageCapacity = _view.StorageCapacity;
            _tank.FuelId = _view.Fuel?.Id;
            _database.SerializeTank(_tank.Id);
        }

        protected sealed override bool ValidateFields(out string message)
        {
            return Validator.ValidateName(_view.TankName, out message);
        }

        #endregion

        public void NavigateToFuel()
        {
            if (_view.Fuel != null)
                _navigator.NavigateToFuel(_view.Fuel.Id);
        }
    }
}
