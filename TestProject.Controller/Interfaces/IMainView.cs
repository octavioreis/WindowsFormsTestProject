using System.Collections.Generic;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IMainView
    {
        IItemsView GetItemsView();
        RegistryType? GetSelectedTab();
        void SelectTab(RegistryType type);
        void ShowFuelsReport(IEnumerable<Fuel> fuels);

        void SetController(MainController controller);
    }
}
