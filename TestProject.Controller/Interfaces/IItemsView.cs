using System;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface IItemsView
    {
        void AddItem(IdentifiedRegistry item);
        void ClearList();
        void RemoveItem(IdentifiedRegistry item);
        void SelectItem(Guid id);
        void SelectItem(IdentifiedRegistry item);
        void ShowWarningMessage(string message);
        void UpdateSelectedItem();

        IRegistryHostView GetRegistryHostView();

        void SetController(ItemsController controller);
    }
}
