using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework_13___Classes
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
