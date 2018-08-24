using System;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class MainController : INavigator
    {
        private readonly IMainView _view;
        private readonly IDatabase _database;
        private readonly ItemsController _itemsController;

        public MainController(IMainView view, IDatabase database)
        {
            _view = view;
            _database = database;

            view.SetController(this);

            _itemsController = new ItemsController(view.GetItemsView(), database, this);
        }

        public void LoadSelectedTab()
        {
            var selectedTabType = _view.GetSelectedTab();
            if (selectedTabType != null)
                _itemsController.LoadItems(selectedTabType.Value);
        }

        public void NavigateToFuel(Guid id)
        {
            NavigateToItem(id, RegistryType.Fuel);
        }

        public void NavigateToTank(Guid id)
        {
            NavigateToItem(id, RegistryType.Tank);
        }

        public void NavigateToNozzle(Guid id)
        {
            NavigateToItem(id, RegistryType.Nozzle);
        }

        private void NavigateToItem(Guid id, RegistryType type)
        {
            _view.SelectTab(type);
            _itemsController.SelectItem(id);
        }

        public void ShowFuelsReport()
        {
            _view.ShowFuelsReport(_database.GetFuels());
        }

        public void ShowTanksReport()
        {
            _view.ShowTanksReport(_database.GetTanks(), _database.GetFuels());
        }

        public void ShowNozzlesReport()
        {
            _view.ShowNozzlesReport(_database.GetNozzles(), _database.GetTanks());
        }
    }
}
