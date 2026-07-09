using System;
using System.Collections.Generic;
using System.Text;
using ParkingGarage.ParkingGate;
using ParkingGarage.Vehicles;

namespace ParkingGarage.Calculators
{
    class RateCalculation
    {
        public double Calculate(Vehicle vehicle,DateTime entryTime, DateTime exitTime)
        {
            vehicle.EntryTime = entryTime;
            vehicle.ExitTime = exitTime;
            

            if (exitTime < entryTime)
            {
                throw new VehicleExitException("Error, no exit time defined.");
            }
            
        
            double duration = exitTime.Hour - entryTime.Hour;
            

            if (vehicle is RegularCar)
            {
                return duration * 15;
            }
            if (vehicle is DisabledCar)
            {
                return duration * 5;
            }
            if (vehicle is Motorcycle)
            {
                return duration * 8;
            }
            else
            {
                throw new ArgumentException("Error: No such vehicle in the system.");
            }
        }


    }
}
