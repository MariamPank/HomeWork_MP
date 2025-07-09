using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework_13___Classes
{
    public class Shape
    {
        private string _name;

        public string Name { get { return _name; } set { _name = value; } }

        public Shape(string name)
        {
            Name = name;
        }
    }
    public class Rectangl_e : Shape
    {
        public Rectangl_e(string name) : base(name)
        {

        }
    }
}
