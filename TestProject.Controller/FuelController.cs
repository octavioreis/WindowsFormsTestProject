using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class FuelController
    {
        private readonly IFuelView _view;
        private readonly IDatabase _database;
        private Fuel _fuel;

        public FuelController(IFuelView view, IDatabase database)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        public void SetFuel(Fuel fuel)
        {
            _fuel = fuel;
            UpdateView();
        }

        public void SetViewVisibility(bool visibility)
        {
            _view.SetViewVisibility(visibility);
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
