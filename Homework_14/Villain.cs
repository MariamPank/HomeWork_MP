using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_14
{
    public class Villain : Character
    {
        public override void Attack (Character target)
        {
            //Villain იყენებს ჯადოს (fireball) და აზიანებს მოწინააღმდეგეს 25 ქულით.
            Console.WriteLine($"{Name} attacks {target.Name} with fireball!");
            target.TakeDamage(25);
        }
    }
}
