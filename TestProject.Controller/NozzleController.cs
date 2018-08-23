using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class NozzleController : AbstractRegistryController
    {
        private readonly INozzleView _view;
        private readonly IDatabase _database;
        private readonly INavigator _navigator;
        private Nozzle _nozzle;
        private IEnumerable<Tank> _tanks;

        public NozzleController(INozzleView view, IDatabase database, INavigator navigator) : base(view)
        {
            _view = view;
            _database = database;
            _navigator = navigator;

            view.SetController(this);
        }

        #region AbstractRegistryController Members

        public override IdentifiedRegistry AddItem()
        {
            var newNozzle = _database.CreateEmptyNozzle();
            _database.AddNozzle(newNozzle);

            return newNozzle;
        }

        public override IdentifiedRegistry GetItem(Guid id)
        {
            return _database.GetNozzle(id);
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return _database.GetNozzles();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            _database.RemoveNozzle(identifiedRegistry.Id);

            return true;
        }

        public override void SetSelectedItem(IdentifiedRegistry identifiedRegistry)
        {
            _nozzle = identifiedRegistry as Nozzle;
            UpdateView();
        }

        public override void SetViewVisibility(bool visible)
        {
            if (visible)
            {
                _tanks = _database.GetTanks();
                _view.SetTankOptions(_tanks);
            }

            base.SetViewVisibility(visible);
        }

        public override void UpdateView()
        {
            _view.NozzleName = _nozzle.Name;
            _view.SellingPrice = _nozzle.SellingPrice;
            _view.Tank = _tanks.FirstOrDefault(f => f.Id == _nozzle.TankId);
        }

        protected sealed override void UpdateModel()
        {
            _nozzle.Name = _view.NozzleName;
            _nozzle.SellingPrice = _view.SellingPrice;
            _nozzle.TankId = _view.Tank.Id;
            _database.SerializeNozzle(_nozzle.Id);

            CallModelChanged();
        }

        protected sealed override bool ValidateFields(out string message)
        {
            return Validator.ValidateName(_view.NozzleName, out message);
        }

        #endregion

        public void NavigateToTank()
        {
            if (_view.Tank != null)
                _navigator.NavigateToTank(_view.Tank.Id);
        }
    }
}
