using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Vehicles;


    abstract class Vehicle
    {
    public string VihecleId;
    public DateTime EntryTime;
    public DateTime? ExitTime;

    protected Vehicle(string vehicleId)
    {
        VihecleId = vehicleId;
    }

    public abstract string GetVihecleType();


}

