using ParkingGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Vehicles
{
    class Motorcycle : Vehicle
    {
        public string VehicleId;
        public Motorcycle(string vehicleId) : base(vehicleId)
        {
            VihecleId = vehicleId;
        }
        public override string GetVihecleType() => $"Motorcycle";
    }
}
