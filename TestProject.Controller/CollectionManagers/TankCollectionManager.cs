using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller.CollectionManagers
{
    public class TankCollectionManager : AbstractCollectionManager
    {
        public TankCollectionManager(IDatabase database) : base(database)
        {
        }

        public override IdentifiedRegistry AddItem()
        {
            var newTank = Database.CreateEmptyTank();

            Database.AddTank(newTank);

            return newTank;
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return Database.GetTanks();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            var nozzlesUsingTank = Database.GetNozzlesUsingTank(identifiedRegistry.Id);
            if (nozzlesUsingTank.Any())
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Não é possível remover o tanque pois os seguintes bicos estão o utilizando:");

                foreach (var nozzle in nozzlesUsingTank)
                {
                    stringBuilder.Append("- ");
                    stringBuilder.AppendLine(nozzle.Name);
                }

                message = stringBuilder.ToString();
                return false;
            }

            Database.RemoveTank(identifiedRegistry.Id);
            return true;
        }
    }
}
