using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.ParkingGate
{
    class VehicleExitException : Exception
    {
        public string Message;
        public VehicleExitException(string message) : base(message)
        {
            Message = message;
        }

    }
}
