
namespace _03BarracksFactory.Models.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Horseman : Unit
    {
        private const int health = 50;
        private const int attackDamage = 10;

        protected Horseman()
            : base(health, attackDamage)
        {

        }
    }
}
