using System;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public class FuelController
    {
        private readonly IFuelView _view;
        private Fuel _fuel;

        public FuelController(IFuelView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public void SetFuel(Fuel fuel)
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
