using System;
using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.Database
{
    public interface IDatabase
    {
        Fuel GetFuel(Guid id);
        Tank GetTank(Guid id);
        Nozzle GetNozzle(Guid id);

        IEnumerable<Fuel> GetFuels();
        IEnumerable<Tank> GetTanks();
        IEnumerable<Nozzle> GetNozzles();

        void AddFuel(Fuel fuel);
        void AddTank(Tank tank);
        void AddNozzle(Nozzle nozzle);

        Fuel CreateEmptyFuel();
        Tank CreateEmptyTank();
        Nozzle CreateEmptyNozzle();

        void RemoveFuel(Guid id);
        void RemoveTank(Guid id);
        void RemoveNozzle(Guid id);

        void SerializeFuel(Guid id);
        void SerializeTank(Guid id);
        void SerializeNozzle(Guid id);

        IEnumerable<Tank> GetTanksUsingFuel(Guid fuelId);
        IEnumerable<Nozzle> GetNozzlesUsingTank(Guid tankId);
    }
}
