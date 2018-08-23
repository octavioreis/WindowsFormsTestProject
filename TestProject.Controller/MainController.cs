using System;
using TestProject.Controller.Interfaces;
using TestProject.Database;

namespace TestProject.Controller
{
    public class MainController
    {
        private readonly IMainView _view;
        private readonly ItemsController _itemsController;

        public MainController(IMainView view, IDatabase database)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            view.SetController(this);

            _itemsController = new ItemsController(view.GetItemsView(), database);
        }

        public void LoadSelectedTab()
        {
            _itemsController.LoadItems(_view.GetSelectedTab());
        }
    }
}
