using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Model;
using TestProject.Model.Enums;

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

        public Fuel GetFuel(Guid id)
        {
            return _fuels.FirstOrDefault(f => f.Id == id);
        }

        public Tank GetTank(Guid id)
        {
            return _tanks.FirstOrDefault(t => t.Id == id);
        }

        public Nozzle GetNozzle(Guid id)
        {
            return _nozzles.FirstOrDefault(n => n.Id == id);
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

        public void AddFuel(Fuel fuel)
        {
            _fuels.Add(fuel);

            SerializeFuel(fuel.Id);
        }

        public void AddTank(Tank tank)
        {
            _tanks.Add(tank);

            SerializeTank(tank.Id);
        }

        public void AddNozzle(Nozzle nozzle)
        {
            _nozzles.Add(nozzle);

            SerializeNozzle(nozzle.Id);
        }

        public Fuel CreateEmptyFuel()
        {
            return new Fuel()
            {
                Id = Guid.NewGuid(),
                Name = string.Concat("Combustível.", _fuels.Count + 1),
                Type = FuelType.CommonGasoline
            };
        }

        public Tank CreateEmptyTank()
        {
            return new Tank()
            {
                Id = Guid.NewGuid(),
                Name = string.Concat("Tanque.", _tanks.Count + 1),
                StorageCapacity = 0f
            };
        }

        public Nozzle CreateEmptyNozzle()
        {
            return new Nozzle()
            {
                Id = Guid.NewGuid(),
                Name = string.Concat("Bico.", _nozzles.Count + 1),
                SellingPrice = 0f
            };
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

        public void SerializeFuel(Guid id)
        {
            //Método para serializar informações do combustível depois que o mesmo for alterado.
        }

        public void SerializeTank(Guid id)
        {
            //Método para serializar informações do tanque depois que o mesmo for alterado.
        }

        public void SerializeNozzle(Guid id)
        {
            //Método para serializar informações do bico depois que o mesmo for alterado.
        }

        public IEnumerable<Tank> GetTanksUsingFuel(Guid fuelId)
        {
            return _tanks.Where(t => t.FuelId == fuelId);
        }

        public IEnumerable<Nozzle> GetNozzlesUsingTank(Guid tankId)
        {
            return _nozzles.Where(n => n.TankId == tankId);
        }
    }
}
