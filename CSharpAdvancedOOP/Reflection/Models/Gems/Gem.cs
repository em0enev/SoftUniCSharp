using InfernoInfinity.Contracts;
using InfernoInfinity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Models.Gems
{
    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;
        
        protected Gem(string clarity)
        {
            this.strength += (int)Enum.Parse(typeof(Clarity), clarity);
            this.agility += (int)Enum.Parse(typeof(Clarity), clarity);
            this.vitality += (int)Enum.Parse(typeof(Clarity), clarity);
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Agility
        {
            get { return this.agility; }
            set { this.agility = value; }
        }

        public int Vitality
        {
            get { return this.vitality; }
            set { this.vitality = value; }
        }
    }
}
