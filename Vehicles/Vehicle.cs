using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Vehicles;


    abstract class Vehicle
    {
    public string VihecleId;

    protected Vehicle(string vihecleId)
    {
        VihecleId = vihecleId;
    }

    public abstract string GetVihecleType();


}

