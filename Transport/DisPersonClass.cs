using System;
namespace ParkingGarage.Transport
{
    class DisPersonCar : Transport
    {
        public DisPersonCar(string carNumber)
            : base(carNumber)
        {

        }
        public override bool Reserve() => true;

        public override int HourMany() => 5;

    }
}