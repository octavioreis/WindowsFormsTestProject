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
        public abstract IdentifiedRegistry GetItem(Guid id);
        public abstract IEnumerable<IdentifiedRegistry> GetItems();
        public abstract void SetSelectedItem(IdentifiedRegistry identifiedRegistry);
        public abstract bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message);
        public abstract void UpdateView();
        protected abstract void UpdateModel();
        protected abstract bool ValidateFields(out string message);

        public virtual void SetViewVisibility(bool visible)
        {
            _view.SetViewVisibility(visible);
        }

        public bool TryUpdateModel(out string message)
        {
            if (ValidateFields(out message))
            {
                UpdateModel();
                return true;
            }
            else
                return false;
        }

        protected void CallModelChanged()
        {
            ModelChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
