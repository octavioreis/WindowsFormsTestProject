using System;

namespace TestProject.Model
{
    public abstract class IdentifiedRegistry
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
