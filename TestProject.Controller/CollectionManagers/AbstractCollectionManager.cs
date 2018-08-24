using System.Collections.Generic;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller.CollectionManagers
{
    public abstract class AbstractCollectionManager
    {
        protected IDatabase Database { get; }

        public AbstractCollectionManager(IDatabase database)
        {
            Database = database;
        }

        public abstract IdentifiedRegistry AddItem();
        public abstract IEnumerable<IdentifiedRegistry> GetItems();
        public abstract bool TryRemoveItem(IdentifiedRegistry identifiedRegistry, out string message);
    }
}
