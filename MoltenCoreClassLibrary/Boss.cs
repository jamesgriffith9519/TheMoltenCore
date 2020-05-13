using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{
   public class Boss : Character
    {//This class will be the enemy Boss mobs that the player can encounter during the molten core raid. 
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value <= MaxDamage && value > 0 ? value : 1;
            }//end set
        }//end MinDamage

        public Boss(string name, int life, int maxLife, int hitRating, int dodgeRating, int minDamage, int maxDamage, string description)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitRating = hitRating;
            DodgeRating = dodgeRating;
            Description = description;

        }//end fqctor

        public override string ToString()
        {
            return string.Format("{0}\nLife:{1} of {2}\nDamage:{3} to {4}\nBlock:{5}\nHit Chance:{6}\nDescription: {7}", Name, Life, MaxLife, MinDamage, MaxDamage, DodgeRating,
                HitRating, Description);
        }//end ToString()

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }









    }//end Class
}//end namespace
