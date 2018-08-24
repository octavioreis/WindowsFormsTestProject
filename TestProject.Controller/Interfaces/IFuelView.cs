using System.Collections.Generic;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IFuelView : IRegistryView
    {
        string FuelName { get; set; }
        FuelType FuelType { get; set; }

        void SetTanksUsingFuel(IEnumerable<Tank> tanks);
    }
}
