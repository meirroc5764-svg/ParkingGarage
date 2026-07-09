using System;
using System.Data;
using ParkingGarage.runningProgram;
namespace ParkingGarage.Transport
{
    abstract class Transport
    {
        private int _carid;

        private string _carNumber;

        private DateTime _timeCameIn;

        private DateTime _timeCameOut;


        public int CarId
        {
            get => _carid; 
        }

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
                _timeCameOut = value;
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
        }
        public DateTime Exit()
        {
           TimeCameOut = DateTime.Now;
        }

    }
}