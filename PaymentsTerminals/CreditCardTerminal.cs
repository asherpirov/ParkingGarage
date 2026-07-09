using ParkingGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.PaymentsTerminals
{
    class CreditCardTerminal : IPaymentTermial
    {
        public string GetTeminalType() => $"Credit Card";
        public bool SucssesPaymant(double amount)
        {
            Console.WriteLine($"Parking payment was made in the {amount} shekels in {GetTeminalType()}.");
            return true;
        }
    }
}
