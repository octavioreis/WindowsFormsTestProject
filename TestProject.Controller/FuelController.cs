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

        public override IdentifiedRegistry AddItem()
        {
            var newFuel = _database.CreateEmptyFuel();
            _database.AddFuel(newFuel);

            return newFuel;
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
            SetSelectedFuel(identifiedRegistry as Fuel);
        }

        private void SetSelectedFuel(Fuel fuel)
        {
            _fuel = fuel;
            UpdateView();
        }

        public void UpdateModel()
        {
            _fuel.Name = _view.FuelName;
            _fuel.Type = _view.FuelType;
        }

        public void UpdateView()
        {
            _view.FuelName = _fuel.Name;
            _view.FuelType = _fuel.Type;
        }
    }
}
