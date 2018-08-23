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
        private readonly NozzleController _nozzleController;

        public ItemsController(IItemsView view, IDatabase database)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _database = database ?? throw new ArgumentNullException(nameof(database)); ;

            view.SetController(this);

            _fuelController = new FuelController(view.GetFuelView(), database);
            _tankController = new TankController(view.GetTankView(), database);
            _nozzleController = new NozzleController(view.GetNozzleView(), database);
        }

        public void LoadItems(RegistryType registryType)
        {
            IEnumerable<IdentifiedRegistry> items = null;
            bool fuelViewVisibility = false;
            bool tankViewVisibility = false;
            bool nozzleViewVisibility = false;

            switch (registryType)
            {
                case RegistryType.Fuel:
                    fuelViewVisibility = true;
                    tankViewVisibility = false;
                    nozzleViewVisibility = false;
                    items = _database.GetFuels();
                    break;
                case RegistryType.Tank:
                    fuelViewVisibility = false;
                    tankViewVisibility = true;
                    nozzleViewVisibility = false;
                    items = _database.GetTanks();
                    break;
                case RegistryType.Nozzle:
                    fuelViewVisibility = false;
                    tankViewVisibility = false;
                    nozzleViewVisibility = true;
                    items = _database.GetNozzles();
                    break;
            }

            _fuelController.SetViewVisibility(fuelViewVisibility);
            _tankController.SetViewVisibility(tankViewVisibility);
            _nozzleController.SetViewVisibility(nozzleViewVisibility);

            LoadItems(items);
        }

        public void SelectedItemChanged(IdentifiedRegistry identifiedRegistry)
        {
            if (identifiedRegistry is Fuel)
                _fuelController.SetFuel(identifiedRegistry as Fuel);
            else if (identifiedRegistry is Tank)
                _tankController.SetTank(identifiedRegistry as Tank);
            else if (identifiedRegistry is Nozzle)
                _nozzleController.SetNozzle(identifiedRegistry as Nozzle);
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
