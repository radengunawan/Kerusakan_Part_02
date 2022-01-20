using System;
using System.Collections.Generic;
using System.Text;

namespace Kerusakan_Part_02
{
    abstract class WeaponDamage
    {
        
        public int Damage { get; protected set; }

        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                this.roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                this.magic = value;
                CalculateDamage();
            }
        }


        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                this.flaming = value;
                CalculateDamage();
            }
        }

        protected abstract void CalculateDamage();

        /*Constructor*/
        public WeaponDamage(int startingRoll)
        {
            this.roll = startingRoll;
            CalculateDamage();
        }
    } //END abstract class WeaponDamage
}
