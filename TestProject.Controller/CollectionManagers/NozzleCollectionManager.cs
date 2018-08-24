using System.Collections.Generic;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller.CollectionManagers
{
    public class NozzleCollectionManager : AbstractCollectionManager
    {
        public NozzleCollectionManager(IDatabase database) : base(database)
        {
        }

        public override IdentifiedRegistry AddItem()
        {
            var newNozzle = Database.CreateEmptyNozzle();

            Database.AddNozzle(newNozzle);

            return newNozzle;
        }

        public override IEnumerable<IdentifiedRegistry> GetItems()
        {
            return Database.GetNozzles();
        }

        public override bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message)
        {
            message = null;

            Database.RemoveNozzle(identifiedRegistry.Id);

            return true;
        }
    }
}
