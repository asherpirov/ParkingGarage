using ParkingGarage.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Interfaces
{
    interface IPayment
    {
        public void PaymentResult(Vehicle vehicle, bool success);
    }
}
