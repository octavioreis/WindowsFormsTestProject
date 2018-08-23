using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface IItemsView
    {
        void AddItem(IdentifiedRegistry item);
        void ClearList();
        void SelectItem(IdentifiedRegistry item);

        IFuelView GetFuelView();
        ITankView GetTankView();
        INozzleView GetNozzleView();

        void SetController(ItemsController controller);
    }
}
