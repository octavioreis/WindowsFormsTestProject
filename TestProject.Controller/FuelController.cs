using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class FuelController : AbstractRegistryController
    {
        private readonly IFuelView _view;
        private readonly IDatabase _database;
        private Fuel _fuel;

        public FuelController(IFuelView view, IDatabase database) : base(view)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        #region AbstractRegistryController Members

        public override IdentifiedRegistry AddItem()
        {
            var newFuel = _database.CreateEmptyFuel();
            _database.AddFuel(newFuel);

            return newFuel;
        }

        public override IdentifiedRegistry GetItem(Guid id)
        {
            return _database.GetFuel(id);
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return _database.GetFuels();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            var tanksUsingFuel = _database.GetTanksUsingFuel(identifiedRegistry.Id);
            if (tanksUsingFuel.Any())
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Não é possível remover o combustível pois os seguintes tanques estão o utilizando:");

                foreach (var tank in tanksUsingFuel)
                {
                    stringBuilder.Append("- ");
                    stringBuilder.AppendLine(tank.Name);
                }

                message = stringBuilder.ToString();
                return false;
            }

            _database.RemoveFuel(identifiedRegistry.Id);
            return true;
        }

        public override void SetSelectedItem(IdentifiedRegistry identifiedRegistry)
        {
            _fuel = identifiedRegistry as Fuel;
            UpdateView();
        }

        public override void UpdateView()
        {
            _view.FuelName = _fuel.Name;
            _view.FuelType = _fuel.Type;
        }

        protected sealed override void UpdateModel()
        {
            _fuel.Name = _view.FuelName;
            _fuel.Type = _view.FuelType;
            _database.SerializeFuel(_fuel.Id);

            CallModelChanged();
        }

        protected sealed override bool ValidateFields(out string message)
        {
            return Validator.ValidateName(_view.FuelName, out message);
        }

        #endregion
    }
}
