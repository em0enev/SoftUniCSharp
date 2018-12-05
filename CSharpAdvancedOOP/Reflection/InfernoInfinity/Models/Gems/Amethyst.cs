using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(string clarity) : base(clarity)
        {
            this.Strength += 2;
            this.Agility += 8;
            this.Vitality += 4;
        }
    }
}
