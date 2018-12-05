using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Weapons
{
    public class Axe : Weapon
    {
        public Axe(string name, string rarity)
            : base(name, rarity)
        {
            this.minDmg = 5;
            this.maxDmg = 10;
            this.socketSlots = new IGem[3];
            ApplyRarity();
        }

        protected override void ApplyRarity()
        {
            base.ApplyRarity();
        }
    }
}
