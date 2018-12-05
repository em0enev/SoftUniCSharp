using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, string rarity) 
            : base(name, rarity)
        {
            this.minDmg = 4;
            this.maxDmg = 6;
            this.socketSlots = new IGem[3];
            ApplyRarity();
        }

        protected override void ApplyRarity()
        {
            base.ApplyRarity();
        }
    }
}
