using System.Collections.Generic;
using System.Linq;
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

        public void LoadItems(IEnumerable<IdentifiedRegistry> items)
        {
            _view.ClearList();

            foreach (var item in items)
                _view.AddItem(item);

            _view.SelectItem(items.FirstOrDefault());
        }
    }
}
