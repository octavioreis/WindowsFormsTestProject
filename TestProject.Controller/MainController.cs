using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model.Enums;

namespace TestProject.Controller
{
    public class MainController
    {
        private readonly IMainView _view;
        private readonly IDatabase _database;
        private readonly ItemsController _itemsController;

        public MainController(IMainView view, IDatabase database)
        {
            view.SetController(this);

            _view = view;
            _database = database;
            _itemsController = new ItemsController(view.GetItemsView());
        }

        public void LoadSelectedTab()
        {
            switch (_view.GetSelectedTab())
            {
                case RegistryType.Fuel:
                    _itemsController.LoadItems(_database.GetFuels());
                    break;
                case RegistryType.Tank:
                    _itemsController.LoadItems(_database.GetTanks());
                    break;
                case RegistryType.Nozzle:
                    _itemsController.LoadItems(_database.GetNozzles());
                    break;
            }
        }
    }
}
