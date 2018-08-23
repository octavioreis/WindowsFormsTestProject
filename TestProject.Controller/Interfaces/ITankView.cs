using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface ITankView
    {
        string TankName { get; set; }
        string StorageCapacity { get; set; }
        Fuel Fuel { get; set; }

        void SetFuelOptions(IEnumerable<Fuel> fuels);
        void SetViewVisibility(bool visible);

        void SetController(TankController controller);
    }
}
