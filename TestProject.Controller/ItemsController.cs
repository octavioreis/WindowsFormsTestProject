using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public class ItemsController
    {
        private readonly IItemsView _view;

        public ItemsController(IItemsView view)
        {
            _view = view;
        }

        public void LoadFuels(IEnumerable<Fuel> fuels)
        {
            foreach (var fuel in fuels)
                _view.AddFuel(fuel);
        }

        public void LoadTanks(IEnumerable<Tank> tanks)
        {
            foreach (var tank in tanks)
                _view.AddTank(tank);
        }

        public void LoadNozzles(IEnumerable<Nozzle> nozzles)
        {
            foreach (var nozzle in nozzles)
                _view.AddNozzle(nozzle);
        }
    }
}
