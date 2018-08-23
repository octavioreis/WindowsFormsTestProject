using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class NozzleController
    {
        private readonly INozzleView _view;
        private readonly IDatabase _database;
        private Nozzle _nozzle;
        private IEnumerable<Tank> _tanks;

        public NozzleController(INozzleView view, IDatabase database)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        public void SetNozzle(Nozzle nozzle)
        {
            _nozzle = nozzle;
            UpdateView();
        }

        public void SetViewVisibility(bool visible)
        {
            if (visible)
            {
                _tanks = _database.GetTanks();
                _view.SetTankOptions(_tanks);
            }

            _view.SetViewVisibility(visible);
        }

        public void UpdateModel()
        {
            _nozzle.Name = _view.NozzleName;
            _nozzle.SellingPrice = _view.SellingPrice;
            _nozzle.TankId = _view.Tank.Id;
        }

        public void UpdateView()
        {
            _view.NozzleName = _nozzle.Name;
            _view.SellingPrice = _nozzle.SellingPrice;
            _view.Tank = _tanks.FirstOrDefault(f => f.Id == _nozzle.TankId);
        }
    }
}
