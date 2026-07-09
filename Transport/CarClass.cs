using ParkingGarage.Interfaces;
using System;
namespace ParkingGarage.Type
{
    internal class Car : Transport
    {
        public Car(string carNumber)
            : base (carNumber)
        {

        }
        public override bool Reserve() => true;

        public override int HourMany() => 15;

    }
}