using TestProject.Model.Enums;

namespace TestProject.Model
{
    public class Fuel : IdentifiedRegistry
    {
        public FuelType Type { get; set; }
    }
}
