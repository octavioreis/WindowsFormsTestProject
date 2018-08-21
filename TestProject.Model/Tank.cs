using System;

namespace TestProject.Model
{
    public class Tank
    {
        public Guid Id { get; set; }

        public float StorageCapacity { get; set; }

        public Guid FuelId { get; set; }
    }
}
