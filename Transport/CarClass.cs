using ParkingGarage.Interfaces;
using System;
namespace ParkingGarage.Transport
{
    class Car : Transport,IParking
    {
        public Car(string carNumber)
            : base (carNumber)
        {

        }
        public override bool Reserve() => true;

        public override int HourMany() => 15;
    }
}