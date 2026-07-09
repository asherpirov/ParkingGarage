using ParkingGarage.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Interfaces
{
    interface IReserable
    {
        public void MakeReservation();
        public void CancelReservation();
    }

}

