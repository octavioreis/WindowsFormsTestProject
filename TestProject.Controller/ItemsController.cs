using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Model;
using TestProject.Model.Enums;

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
            _view.ShowFuelRegistry();

            LoadItems(fuels);
        }

        public void LoadTanks(IEnumerable<Tank> tanks)
        {
            _view.ShowTankRegistry();

            LoadItems(tanks);
        }

        public void LoadNozzles(IEnumerable<Nozzle> nozzles)
        {
            _view.ShowNozzleRegistry();

            LoadItems(nozzles);
        }

        private void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }
    }
}
