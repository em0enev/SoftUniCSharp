using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(string clarity)
            : base(clarity)
        {
            this.Strength += 1;
            this.Agility += 4;
            this.Vitality += 9;
        }
    }
}
