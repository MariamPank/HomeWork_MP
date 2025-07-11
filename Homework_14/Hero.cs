using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    public class Hero : Character
    {
        public override void Attack(Character target)
        {
            //Hero იყენებს ხმალს (sword) და აზიანებს მოწინააღმდეგეს 20 ქულით.
            Console.WriteLine($"{Name} attacks {target.Name} with Sword!");
            target.TakeDamage(20);
        }
    }
}
