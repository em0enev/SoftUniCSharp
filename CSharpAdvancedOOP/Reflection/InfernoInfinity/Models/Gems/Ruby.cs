using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(string clarity)
            : base(clarity)
        {
            this.Strength += 7;
            this.Agility += 2;
            this.Vitality += 5;
        }
    }
}
