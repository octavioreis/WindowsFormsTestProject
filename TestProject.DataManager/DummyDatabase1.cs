﻿using System;
using System.Collections.Generic;
using TestProject.Model;
using TestProject.Model.Enums;

namespace TestProject.Database
{
    public class DummyDatabase1 : AbstractDummyDatabase
    {
        protected override List<Fuel> CreateFuelsList()
        {
            return new List<Fuel>()
            {
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.1", Type = FuelType.CommonGasoline },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.2", Type = FuelType.Diesel },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.3", Type = FuelType.AdditivatedGasoline },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.4", Type = FuelType.AdditivatedGasoline },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.5", Type = FuelType.CommonGasoline },
                new Fuel() { Id = Guid.NewGuid(), Name = "Combustivel.6", Type = FuelType.Etanol},
            };
        }

        protected override List<Tank> CreateTanksList(List<Fuel> fuels)
        {
            return new List<Tank>()
            {
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.1", StorageCapacity = "25.5", FuelId = fuels[2].Id },
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.2", StorageCapacity = "50", FuelId = fuels[0].Id },
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.3", StorageCapacity = "37", FuelId = fuels[1].Id },
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.4", StorageCapacity = "20", FuelId = fuels[5].Id },
                new Tank() { Id = Guid.NewGuid(), Name = "Tanque.5", StorageCapacity = "35.7", FuelId = fuels[5].Id },
            };
        }

        protected override List<Nozzle> CreateNozzlesList(List<Tank> tanks)
        {
            return new List<Nozzle>()
            {
                new Nozzle() { Id = Guid.NewGuid(), Name = "Bico.1", SellingPrice = "4.05", TankId = tanks[2].Id },
                new Nozzle() { Id = Guid.NewGuid(), Name = "Bico.2", SellingPrice = "3.65", TankId = tanks[3].Id },
                new Nozzle() { Id = Guid.NewGuid(), Name = "Bico.3", SellingPrice = "4.57", TankId = tanks[0].Id },
            };
        }
    }
}
