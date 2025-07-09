using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework_13___Classes
{
    public class Printer
    {
        public void Print(string txt)
        {
            Console.WriteLine($"Ordinary Printer {txt}");
        }
    }
    public class ColorPrinter : Printer
    {
        public new void Print(decimal numb)
        {
            Console.WriteLine($"Color Printer {numb}");
        }
    }
}
