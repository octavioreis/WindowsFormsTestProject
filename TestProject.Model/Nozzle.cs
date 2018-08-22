using System;

namespace TestProject.Model
{
    public class Nozzle
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string SellingPrice { get; set; }

        public Guid TankId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
