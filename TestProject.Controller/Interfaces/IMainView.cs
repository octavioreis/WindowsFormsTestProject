using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IMainView
    {
        IItemsView GetItemsView();
        RegistryType GetSelectedTab();

        void SetController(MainController controller);
    }
}
