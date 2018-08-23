using System;

namespace TestProject.Model
{
    public class Nozzle : IdentifiedRegistry
    {
        public string SellingPrice { get; set; }

        public Guid? TankId { get; set; }
    }
}
