using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Model;

namespace TestProject.Database
{
    public abstract class AbstractDummyDatabase : IDatabase
    {
        private readonly List<Fuel> _fuels;
        private readonly List<Tank> _tanks;
        private readonly List<Nozzle> _nozzles;

        protected abstract List<Fuel> CreateFuelsList();
        protected abstract List<Tank> CreateTanksList(List<Fuel> fuels);
        protected abstract List<Nozzle> CreateNozzlesList(List<Tank> tanks);

        public AbstractDummyDatabase()
        {
            _fuels = CreateFuelsList();
            _tanks = CreateTanksList(_fuels);
            _nozzles = CreateNozzlesList(_tanks);
        }

        public void AddFuel(Fuel fuel)
        {
            _fuels.Add(fuel);
        }

        public void AddTank(Tank tank)
        {
            _tanks.Add(tank);
        }

        public void AddNozzle(Nozzle nozzle)
        {
            _nozzles.Add(nozzle);
        }

        public IEnumerable<Fuel> GetFuels()
        {
            return _fuels.AsEnumerable();
        }

        public IEnumerable<Tank> GetTanks()
        {
            return _tanks.AsEnumerable();
        }

        public IEnumerable<Nozzle> GetNozzles()
        {
            return _nozzles.AsEnumerable();
        }

        public void RemoveFuel(Guid id)
        {
            _fuels.Remove(_fuels.FirstOrDefault(f => f.Id == id));
        }

        public void RemoveTank(Guid id)
        {
            _tanks.Remove(_tanks.FirstOrDefault(t => t.Id == id));
        }

        public void RemoveNozzle(Guid id)
        {
            _nozzles.Remove(_nozzles.FirstOrDefault(n => n.Id == id));
        }
    }
}
