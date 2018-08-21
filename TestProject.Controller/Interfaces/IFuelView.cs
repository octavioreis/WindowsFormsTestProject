using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface IFuelView
    {
        string FuelName { get; set; }
        FuelType FuelType { get; set; }

        void SetController(FuelController controller);
    }
}
