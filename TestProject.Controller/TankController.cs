using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class TankController : AbstractRegistryController
    {
        private readonly ITankView _view;
        private readonly IDatabase _database;
        private Tank _tank;
        private IEnumerable<Fuel> _fuels;

        public TankController(ITankView view, IDatabase database) : base(view)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        #region AbstractRegistryController Members

        public override IdentifiedRegistry AddItem()
        {
            var newTank = _database.CreateEmptyTank();
            _database.AddTank(newTank);

            return newTank;
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return _database.GetTanks();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            var nozzlesUsingTank = _database.GetNozzlesUsingTank(identifiedRegistry.Id);
            if (nozzlesUsingTank.Any())
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Não é possível remover o tanque pois os seguintes bicos estão o utilizando:");

                foreach (var nozzle in nozzlesUsingTank)
                {
                    stringBuilder.Append("- ");
                    stringBuilder.AppendLine(nozzle.Name);
                }

                message = stringBuilder.ToString();
                return false;
            }

            _database.RemoveTank(identifiedRegistry.Id);
            return true;
        }

        public override void SetSelectedItem(IdentifiedRegistry identifiedRegistry)
        {
            SetSelectedTank(identifiedRegistry as Tank);
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

        public void SetSelectedTank(Tank tank)
        {
            _tank = tank;
            UpdateView();
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

            CallModelChanged();
        }

        protected sealed override bool ValidateFields(out string message)
        {
            if (!Validator.ValidateName(_view.TankName, out message))
                return false;

            if (!Validator.ValidateName(_view.StorageCapacity, out message))
                return false;

            return true;
        }

        #endregion
    }
}
