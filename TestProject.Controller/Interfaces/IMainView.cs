using System.Collections.Generic;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IMainView
    {
        RegistryType? GetSelectedTab();
        void SelectTab(RegistryType type);
        void ShowFuelsReport(IEnumerable<Fuel> fuels);
        void ShowTanksReport(IEnumerable<Tank> tanks, IEnumerable<Fuel> fuels);
        void ShowNozzlesReport(IEnumerable<Nozzle> nozzles, IEnumerable<Tank> tanks);

        IItemsView GetItemsView();

        void SetController(MainController controller);
    }
}
