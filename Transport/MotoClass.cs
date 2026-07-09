using System;
namespace ParkingGarage.Transport
{
    class Moto: Transport
    {
        public Moto(int carId, string carNumber, DateTime timeCameIn)
            : base(carId, carNumber, timeCameIn)
        {

        }
        public override string TransportType() => "Moto";

    }
}