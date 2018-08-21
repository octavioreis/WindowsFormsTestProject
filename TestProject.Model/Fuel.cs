using System;

namespace TestProject.Model
{
    public class Fuel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public FuelType Type { get; set; }
    }
}
