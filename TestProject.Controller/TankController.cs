using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class TankController
    {
        private readonly ITankView _view;
        private readonly IDatabase _database;
        private Tank _tank;
        private IEnumerable<Fuel> _fuels;

        public TankController(ITankView view, IDatabase database)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        public void SetTank(Tank tank)
        {
            _tank = tank;
            UpdateView();
        }

        public void SetViewVisibility(bool visible)
        {
            if (visible)
            {
                _fuels = _database.GetFuels();
                _view.SetFuelOptions(_fuels);
            }

            _view.SetViewVisibility(visible);
        }

        public void UpdateModel()
        {
            _tank.Name = _view.TankName;
            _tank.StorageCapacity = _view.StorageCapacity;
            _tank.FuelId = _view.Fuel.Id;
        }

        public void UpdateView()
        {
            _view.TankName = _tank.Name;
            _view.StorageCapacity = _tank.StorageCapacity;
            _view.Fuel = _fuels.FirstOrDefault(f => f.Id == _tank.FuelId);
        }
    }
}
