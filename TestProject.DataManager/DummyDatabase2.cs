using System;
using System.Collections.Generic;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Database
{
    public class DummyDatabase2 : AbstractDummyDatabase
    {
        protected override List<Fuel> CreateFuelsList()
        {
            return new List<Fuel>()
            {
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustível.1", Type = FuelType.CommonGasoline },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustível.2", Type = FuelType.AdditivatedGasoline }
            };
        }

        protected override List<Tank> CreateTanksList(List<Fuel> fuels)
        {
            return new List<Tank>()
            {
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.1", StorageCapacity = 20f, FuelId = fuels[0].Id },
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.2", StorageCapacity = 25.5f, FuelId = fuels[1].Id }
            };
        }

        protected override List<Nozzle> CreateNozzlesList(List<Tank> tanks)
        {
            return new List<Nozzle>()
            {
                new Nozzle() { Id = Guid.NewGuid(), Name = "Bico.1", SellingPrice = "4.05", TankId = tanks[0].Id },
                new Nozzle() { Id = Guid.NewGuid(), Name = "Bico.2", SellingPrice = "4.20", TankId = tanks[1].Id }
            };
        }
    }
}
