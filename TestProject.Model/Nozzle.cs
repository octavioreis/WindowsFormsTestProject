using System;

namespace TestProject.Model
{
    public class Nozzle : IdentifiedRegistry
    {
        public float SellingPrice { get; set; }

        public Guid? TankId { get; set; }
    }
}
