using System;

namespace TestProject.Model
{
    public class Tank : IdentifiedRegistry
    {
        public float StorageCapacity { get; set; }

        public Guid? FuelId { get; set; }
    }
}
