using System;
using System.Collections.Generic;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.Controller
{
    public abstract class AbstractRegistryController
    {
        private readonly IRegistryView _view;
        public event EventHandler ModelChanged;

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

        protected void CallModelChanged()
        {
            ModelChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
