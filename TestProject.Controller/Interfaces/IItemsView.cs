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
        void ShowErrorMessage(string message);
        void UpdateSelectedItem();

        IFuelView GetFuelView();
        ITankView GetTankView();
        INozzleView GetNozzleView();

        void SetController(ItemsController controller);
    }
}
