using System;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface IItemsView
    {
        void AddItem(IdentifiedRegistry item);
        void ClearList();
        void RemoveItem(IdentifiedRegistry item);
        void SelectItem(IdentifiedRegistry item);
        void SelectItem(Guid id);
        void ShowErrorMessage(string message);

        IFuelView GetFuelView();
        ITankView GetTankView();
        INozzleView GetNozzleView();

        void SetController(ItemsController controller);
    }
}
