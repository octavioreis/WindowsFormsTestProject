using System;
using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.DataManager
{
    public class DummyDatabase1 : IDataBase
    {
        public void AddFuel(Fuel fuel)
        {
            throw new NotImplementedException();
        }

        public void AddNozzle(Nozzle nozzle)
        {
            throw new NotImplementedException();
        }

        public void AddTank(Tank tank)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fuel> GetFuels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Nozzle> GetNozzles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tank> GetTanks()
        {
            throw new NotImplementedException();
        }

        public void RemoveFuel(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveNozzle(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveTank(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
