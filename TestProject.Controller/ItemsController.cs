using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public class ItemsController
    {
        private readonly IItemsView _view;
        private readonly FuelController _fuelController;

        public ItemsController(IItemsView view)
        {
            view.SetController(this);

            _view = view;
            _fuelController = new FuelController(view.GetFuelView());
        }

        public void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }

        public void SelectedItemChanged(IdentifiedRegistry identifiedRegistry)
        {
            if (identifiedRegistry is Fuel)
            {
                _fuelController.SetFuel(identifiedRegistry as Fuel);
                _fuelController.SetViewVisibility(true);
            }
            else if (identifiedRegistry is Tank)
            {

            }
            else if (identifiedRegistry is Nozzle)
            {

            }
        }
    }
}
