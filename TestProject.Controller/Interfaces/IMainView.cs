using TestProject.Controller.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IMainView
    {
        void SetController(MainController controller);

        IItemsView GetItemsView();
        RegistryType GetSelectedTab();
    }
}
