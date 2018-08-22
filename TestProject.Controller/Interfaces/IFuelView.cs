using TestProject.Model.Enums;

namespace TestProject.Controller.Interfaces
{
    public interface IFuelView
    {
        string FuelName { get; set; }
        FuelType FuelType { get; set; }

        void SetViewVisibility(bool visible);

        void SetController(FuelController controller);
    }
}
