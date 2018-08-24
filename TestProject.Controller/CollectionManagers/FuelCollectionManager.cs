using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller.CollectionManagers
{
    public class FuelCollectionManager : AbstractCollectionManager
    {
        public FuelCollectionManager(IDatabase database) : base(database)
        {
        }

        public override IdentifiedRegistry AddItem()
        {
            var newFuel = Database.CreateEmptyFuel();

            Database.AddFuel(newFuel);

            return newFuel;
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return Database.GetFuels();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            var tanksUsingFuel = Database.GetTanksUsingFuel(identifiedRegistry.Id);
            if (tanksUsingFuel.Any())
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Não é possível remover o combustível pois os seguintes tanques estão o utilizando:");

                foreach (var tank in tanksUsingFuel)
                {
                    stringBuilder.Append("- ");
                    stringBuilder.AppendLine(tank.Name);
                }

                message = stringBuilder.ToString();
                return false;
            }

            Database.RemoveFuel(identifiedRegistry.Id);
            return true;
        }
    }
}
