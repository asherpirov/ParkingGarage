using ParkingGarage.Calculators;
using ParkingGarage.Vehicles;
using System;

namespace ParkingGarage;

class Program
{
    public static void Main()
    {
        RegularCar a = new RegularCar("1234567");
        RateCalculation calculator = new RateCalculation();


        Console.WriteLine(calculator.Calculate(a, DateTime.Now, DateTime.Now.AddHours(2)));

    }
}