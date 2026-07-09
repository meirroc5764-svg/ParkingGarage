using System;
using System.Data;
using ParkingGarage.runningProgram;
namespace ParkingGarage.Type
{ 
    abstract class Transport
    {

        private string _carNumber;

        private DateTime _timeCameIn;

        private DateTime _timeCameOut;


        public string CarNumber
        {
            get => _carNumber;
            set => _carNumber = value;
        }
        public DateTime TimeCameIn
        {
            get => _timeCameIn;
            set
            {
                if(DateTime.Now > _timeCameIn)
                {
                    _timeCameIn = DateTime.Now;
                }
                else
                {
                    _timeCameIn = value;
                }
            }
        }
        public  DateTime TimeCameOut
        {
            get => _timeCameOut;
            set
            {
                if (value < _timeCameIn)
                {
                    _timeCameIn = DateTime.Now;
                }
                else
                {
                    _timeCameIn = value;
                }
            }
        }
        public bool Isvalid;

        public Transport(string carNumber)
        {
            CarNumber = carNumber;
            Isvalid = true;
        }
        abstract public bool Reserve();
        abstract public int HourMany();

        public DateTime Enter()
        {
            TimeCameIn = DateTime.Now;
            return TimeCameIn;
        }
        public DateTime Exit()
        {
            TimeCameIn = DateTime.Now;
            return TimeCameIn;
        }

    }
}