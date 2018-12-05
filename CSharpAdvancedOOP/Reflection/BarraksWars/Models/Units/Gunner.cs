
namespace _03BarracksFactory.Models.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Gunner : Unit
    {

        protected Gunner()
            : base(health: 20, attackDamage: 20)
        {
        }
    }
}
