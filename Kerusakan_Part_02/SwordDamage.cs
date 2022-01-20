using System;
using System.Collections.Generic;
using System.Text;

namespace Kerusakan_Part_02
{
    class SwordDamage : WeaponDamage
    {

        public SwordDamage(int startingRoll) : base(startingRoll) { }

        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;


        /*
      * Base constructor:
      * public WeaponDamage(int startingRoll)
     {
         this.roll = startingRoll;
         CalculateDamage();
     }
      */


        

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (this.Magic) magicMultiplier = 1.75M;

            this.Damage = BASE_DAMAGE;
            this.Damage = (int)(this.Roll * magicMultiplier) + BASE_DAMAGE;
            
            if (this.Flaming) this.Damage += FLAME_DAMAGE;
        }

    }
}
