using ParkingGarage.Interfaces;
using ParkingGarage.Type;
using System;
namespace ParkingGarage.Parking
{
    class Parking:IPayCart,IPayCash
    {
        List<Transport> transportList = new List<Transport>();//I would create a separate class for this
        public int CalculatePay(Transport transport)
        {
            DateTime dataCameIn = transport.TimeCameOut;  
            DateTime datecameOut = transport.TimeCameIn;
            return (datecameOut.Hour - dataCameIn.Hour);
        }
        
        public void GetOut(Transport transport)
        {
            bool choise = false;
            transport.Exit();
            Console.WriteLine(" 1 cart");
            Console.WriteLine("2 cash");
            while (choise == false)
            {
                string user_input = Console.ReadLine();
                if (user_input == "1")
                {
                    PayCart();
                    choise = true;
                }
                    
                if (user_input == "2")
                {
                    PayCash();
                    choise=true;
                }
                else
                Console.WriteLine("enter 1 or 2");
            }
            

        }
        public void CameInParking(Transport transport)
        {

        }
        public void PayCart()
        {
            Console.WriteLine("he pay with cart");
        }
        public void PayCash()
        {
            Console.WriteLine("he pay cash");
        }

    }
}