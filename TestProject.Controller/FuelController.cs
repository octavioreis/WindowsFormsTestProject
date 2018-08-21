using System;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public class FuelController
    {
        private readonly IFuelView _view;
        private readonly Fuel _fuel;

        public FuelController(IFuelView view, Fuel fuel)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _fuel = fuel ?? throw new ArgumentNullException(nameof(fuel));
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
