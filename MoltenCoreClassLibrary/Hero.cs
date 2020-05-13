using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{//what properties would i want to be specific to my hero?
    // Equipped Weapon, Equipped Armor, Race, 
   public  class Hero : Character
    {

        public Race HeroRace { get; set; }
        public HeroClass HeroClass { get; set; }
        public string HeroTitle { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }



        public Hero(string name, int hitRating, int dodgeRating, int life, int maxLife, Race heroRace, HeroClass heroClass,string heroTitle, Weapon equippedWeapon, Armor equippedArmor) 
        {
            Name = name;
            HeroRace = heroRace;
            HeroClass = heroClass;
            HeroTitle = heroTitle;
            EquippedWeapon = equippedWeapon;
            EquippedArmor = equippedArmor;
            HitRating = hitRating;
            DodgeRating = dodgeRating + EquippedArmor.BonusDodgeRating;
            MaxLife = maxLife + EquippedArmor.BonusLife + EquippedWeapon.BonusLife;
            Life = life;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n\nRace: {2}\nClass: {3}\nLife: {4}/{5}\nHit Rating: {6}\nDodge Rating: {7}{8}\n{9}",Name, HeroTitle, HeroRace, HeroClass, Life, MaxLife, 
                HitRating + EquippedWeapon.BonusHitRating, DodgeRating, EquippedWeapon,
                EquippedArmor);
        }

        public override int CalcDamage()
        {

            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;
        }//end calc damage


        public override int CalcHitRating()
        {
            return HitRating + EquippedWeapon.BonusHitRating;
        }//end CalcHitChance

        public override int CalcDodgeRating()
        {
            return DodgeRating + EquippedArmor.BonusDodgeRating;
        }

        public override int CalcBonusLife()
        {
            return MaxLife + EquippedArmor.BonusLife + EquippedWeapon.BonusLife;
            
        }

        public override int CalcLife()
        {
            return Life;
            //return Life + EquippedArmor.BonusLife + EquippedWeapon.BonusLife;
        }


    }//end Class
}
