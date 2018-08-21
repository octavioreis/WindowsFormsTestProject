using System;
using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.DataManager
{
    public interface IDataBase
    {
        IEnumerable<Fuel> GetFuels();
        IEnumerable<Tank> GetTanks();
        IEnumerable<Nozzle> GetNozzles();

        void AddFuel(Fuel fuel);
        void AddTank(Tank tank);
        void AddNozzle(Nozzle nozzle);

        void RemoveFuel(Guid id);
        void RemoveTank(Guid id);
        void RemoveNozzle(Guid id);
    }
}
