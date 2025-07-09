using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework_13___Classes
{
    public class Transport
    {
        private decimal _speed;

        public decimal Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void Move(decimal speed)
        {
            Speed = speed;
            Console.WriteLine($"I'm moving at {speed} km per hour");
        }
    }
    public class Car : Transport
    {
        private string _fuelType = "";

        public void Drive(string fuelType)
        {
            FuelTupe = fuelType;
            Console.WriteLine($"I only drive with {fuelType}");
        }

        public string FuelTupe
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }
    }
}
