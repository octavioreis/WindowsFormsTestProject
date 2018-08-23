using System;
using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class MainController : INavigator
    {
        private readonly IMainView _view;
        private readonly ItemsController _itemsController;

        public MainController(IMainView view, IDatabase database)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
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
    }
}
