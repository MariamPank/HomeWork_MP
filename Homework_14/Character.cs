using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    public abstract class Character
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public bool IsAlive
        {
            get
            {
                return _health > 0;
            }
        }

        public abstract void Attack(Character target);

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }


    }
}
