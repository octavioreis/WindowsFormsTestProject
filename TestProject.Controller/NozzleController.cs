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
        private Nozzle _nozzle;
        private IEnumerable<Tank> _tanks;

        public NozzleController(INozzleView view, IDatabase database) : base(view)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        public override IdentifiedRegistry AddItem()
        {
            var newNozzle = _database.CreateEmptyNozzle();
            _database.AddNozzle(newNozzle);

            return newNozzle;
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
            SetSelectedNozzle(identifiedRegistry as Nozzle);
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

        public void SetSelectedNozzle(Nozzle nozzle)
        {
            _nozzle = nozzle;
            UpdateView();
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
