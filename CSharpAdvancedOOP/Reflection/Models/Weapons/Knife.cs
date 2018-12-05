using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name, string rarity) 
            : base(name, rarity)
        {
            this.minDmg = 3;
            this.maxDmg = 4;
            this.socketSlots = new IGem[2];
            ApplyRarity();
        }

        protected override void ApplyRarity()
        {
            base.ApplyRarity();
        }
    }
}
