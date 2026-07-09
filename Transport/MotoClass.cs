using ParkingGarage.Interfaces;
using System;
namespace ParkingGarage.Type
{
    class Moto : Transport
    {
        public Moto(string carNumber)
            : base(carNumber)
        {
            TimeCameIn = DateTime.Now;
        }
        public override bool Reserve() => false;
        public override int HourMany() => 8;

    }
}