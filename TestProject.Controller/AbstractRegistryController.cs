using System.Collections.Generic;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public abstract class AbstractRegistryController
    {
        private readonly IRegistryView _view;

        public AbstractRegistryController(IRegistryView view)
        {
            _view = view;
        }

        public abstract IdentifiedRegistry AddItem();
        public abstract IEnumerable<IdentifiedRegistry> GetItems();
        public abstract void SetSelectedItem(IdentifiedRegistry identifiedRegistry);
        public abstract bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message);

        public virtual void SetViewVisibility(bool visible)
        {
            _view.SetViewVisibility(visible);
        }
    }
}
