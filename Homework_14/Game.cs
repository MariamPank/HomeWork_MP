using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{

    public class Game
    {
        public void Start()
        {
            Hero hero = new Hero();
            Villain villain = new Villain();

            Console.WriteLine("Game Start!");
            Console.WriteLine("Please state the name of the Hero");
            hero.Name = Console.ReadLine();
            hero.Health = 100;
            Console.WriteLine("Please state the name of the Villain");
            villain.Name = Console.ReadLine();
            villain.Health = 100;
            Console.WriteLine($"{hero.Name} vs {villain.Name}");


            Console.WriteLine($"Current Health Score: Hero - {hero.Health}, Villain - {villain.Health}");


            while (hero.IsAlive && villain.IsAlive)
            {
                hero.Attack(villain);
                if (villain.IsAlive)
                {
                    villain.Attack(hero);
                }

                Console.WriteLine($"{hero.Name} Residual Points: {hero.Health}");
                Console.WriteLine($"{villain.Name} Residual Points: {villain.Health}");
                Console.WriteLine("Another Round");
            }

            if (hero.IsAlive)
            {
                Console.WriteLine($"{hero.Name} wins!");
            }
            else if (villain.IsAlive) 
            {
                Console.WriteLine($"{villain.Name} wins!");
            }
            else
            {
                Console.WriteLine("The score is even!");
            }
        }
    }
}
