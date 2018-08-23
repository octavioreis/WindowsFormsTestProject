using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface ITankView : IRegistryView
    {
        string TankName { get; set; }
        float StorageCapacity { get; set; }
        Fuel Fuel { get; set; }

        void SetFuelOptions(IEnumerable<Fuel> fuels);
        void SetController(TankController controller);
    }
}
