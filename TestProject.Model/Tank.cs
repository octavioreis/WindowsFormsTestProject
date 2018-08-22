using System;

namespace TestProject.Model
{
    public class Tank
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string StorageCapacity { get; set; }

        public Guid FuelId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
