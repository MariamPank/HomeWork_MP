using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework_13___Classes
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age must be at least 18.")
        {
        }
    }
}
