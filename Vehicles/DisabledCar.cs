using ParkingGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Vehicles
{
    class DisabledCar : Vehicle, IReserable
    {
        public string VehicleId;
        public bool IsOrder = false;

        public DisabledCar(string vehicleId) : base(vehicleId)
        {
            VihecleId = vehicleId;
        }

        public override string GetVihecleType() => $"Disabled Car";
        public void MakeReservation() => IsOrder = true;
        public void CancelReservation() => IsOrder = false;
    }
}
    