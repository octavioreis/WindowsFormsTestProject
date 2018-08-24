using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IFuelView : IRegistryView
    {
        string FuelName { get; set; }
        FuelType FuelType { get; set; }
    }
}
