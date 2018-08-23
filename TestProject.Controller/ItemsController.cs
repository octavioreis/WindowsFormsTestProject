using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class ItemsController
    {
        private readonly IItemsView _view;
        private readonly IDatabase _database;
        private readonly FuelController _fuelController;
        private readonly TankController _tankController;

        public ItemsController(IItemsView view, IDatabase database)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _database = database ?? throw new ArgumentNullException(nameof(database)); ;

            view.SetController(this);

            _fuelController = new FuelController(view.GetFuelView(), database);
            _tankController = new TankController(view.GetTankView(), database);
        }

        public void LoadItems(RegistryType registryType)
        {
            IEnumerable<IdentifiedRegistry> items = null;

            switch (registryType)
            {
                case RegistryType.Fuel:
                    _fuelController.SetViewVisibility(true);
                    _tankController.SetViewVisibility(false);

                    items = _database.GetFuels();
                    break;
                case RegistryType.Tank:
                    _fuelController.SetViewVisibility(false);
                    _tankController.SetViewVisibility(true);

                    items = _database.GetTanks();
                    break;
                case RegistryType.Nozzle:
                    _fuelController.SetViewVisibility(false);
                    _tankController.SetViewVisibility(false);

                    items = _database.GetNozzles();
                    break;
            }

            LoadItems(items);
        }

        public void SelectedItemChanged(IdentifiedRegistry identifiedRegistry)
        {
            if (identifiedRegistry is Fuel)
                _fuelController.SetFuel(identifiedRegistry as Fuel);
            else if (identifiedRegistry is Tank)
                _tankController.SetTank(identifiedRegistry as Tank);
            else if (identifiedRegistry is Nozzle)
            {

            }
        }

        public void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }
    }
}
