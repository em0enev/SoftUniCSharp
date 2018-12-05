using InfernoInfinity.Contracts;
using InfernoInfinity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InfernoInfinity.Models
{
    public abstract class Weapon : IWeapon
    {
        private string name;
        protected int minDmg;
        protected int maxDmg;
        protected IGem[] socketSlots;
        private int rarity;

        protected Weapon(string name, string rarity)
        {
            this.Name = name;
            this.rarity = (int)Enum.Parse(typeof(Rarity), rarity);
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int MinDmg
        {
            get { return this.minDmg + TotalStrength * 2 + TotalAgility * 1; }
            private set { this.minDmg = (int)value; }
        }

        public int MaxDmg
        {
            get { return this.maxDmg + TotalStrength * 3 + TotalAgility * 4; }
            private set { this.maxDmg = value; }
        }

        public int TotalAgility
        {
            get
            {
                int sum = 0;
                foreach (var item in socketSlots)
                {
                    if (item != null)
                    {
                        sum += item.Agility;
                    }
                }
                return sum;
            }
        }

        public int TotalStrength
        {
            get
            {
                int sum = 0;
                foreach (var item in socketSlots)
                {
                    if (item != null)
                    {
                        sum += item.Strength;
                    }
                }
                return sum;
            }

        }
        public int TotalVitality
        {
            get
            {
                int sum = 0;
                foreach (var item in socketSlots)
                {
                    if (item != null)
                    {
                        sum += item.Vitality;
                    }
                }
                return sum;
            }

        }

        public IReadOnlyCollection<IGem> Sockets
        {
            get { return Array.AsReadOnly(socketSlots); }
        }

        protected virtual void ApplyRarity()
        {
            this.minDmg *= rarity;
            this.maxDmg *= rarity;
        }

        public void AddGem(int slot, IGem gem)
        {
            if (slot >= 0 && slot <= socketSlots.Length - 1)
            {
                socketSlots[slot] = gem;
            }
        }

        public void RemoveGem(int slot)
        {
            if (slot >= 0 && slot <= socketSlots.Length - 1)
            {
                socketSlots[slot] = null;
            }
        }
    }
}
