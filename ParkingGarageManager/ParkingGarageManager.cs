using System;
using System.Collections.Generic;
using System.Text;
using ParkingGarage.Vehicles;
using ParkingGarage.Calculators;
using ParkingGarage.PaymentsTerminals;


namespace ParkingGarage.ParkingGarageManager
{
    class ParkingGarageManager
    {
        public RateCalculation calculator = new RateCalculation();
        public List<Vehicle> ParkedVehicles = new List<Vehicle>();
        public List<Vehicle> NotParkedVehicles = new List<Vehicle>();

        public ParkingGarageManager(Vehicle vehicle)
        {
             
        }

    }
}
