using System;
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

        public abstract string GetSaveButtonTooltip();
        public abstract void UpdateViewItem(IdentifiedRegistry identifiedRegistry);
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
                ModelChanged?.Invoke(this, EventArgs.Empty);

                return true;
            }

            return false;
        }
    }
}
