using System;

namespace TestProject.Model
{
    public class Tank : IdentifiedRegistry
    {
        public string StorageCapacity { get; set; }

        public Guid? FuelId { get; set; }
    }
}
