using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{
   public class Weapon
    {
        private int _minDamage;
        public string Name { get; set; }
        public Rarity WeaponRarity { get; set; }
        public int MaxDamage { get; set; }
        public int BonusHitRating { get; set; }
        public int BonusLife { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value < MaxDamage ? value : 1;
            }
        }

        public Weapon(string name, Rarity weaponRarity, int minDamage, int maxDamage, int bonusHitRating, int bonusLife)
        {
            Name = name;
            WeaponRarity = weaponRarity;
            MaxDamage = maxDamage;
            BonusHitRating = bonusHitRating;
            MinDamage = minDamage;
            BonusLife = bonusLife;

        }

        public override string ToString()
        {
            return string.Format("\nWeapon: {0}\nWeapon Rarity: {1}\nMin - Max Damage: {2} --- {3}\nBonus Hit Rating: {4}\nBonus Life {5}", Name, WeaponRarity, MinDamage, MaxDamage, BonusHitRating, BonusLife);
        }









    }//end class Weapon

}
