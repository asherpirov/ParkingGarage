using ParkingGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Vehicles
{
    class RegularCar : Vehicle, IReserable
    {
        public string VehicleId;
        public bool IsOrder = false;

        public RegularCar(string vehicleId) : base(vehicleId)
        {
            VihecleId = vehicleId;
        }

        public override string GetVihecleType() => $"Regular Car";
        public void MakeReservation() => IsOrder = true;
        public void CancelReservation() => IsOrder = false;
    }
}
