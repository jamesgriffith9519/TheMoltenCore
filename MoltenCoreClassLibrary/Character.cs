using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{
   public class Character
    {
        //what kind of properties would i want to give to every kind of charecter, player, monster, trash packs, ect.
        //name, dodge chance, hit chance, life, max life.

        private int _life;
        public string Name { get; set; }
        public int HitRating { get; set; }
        public int DodgeRating { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }
        }

        public virtual int CalcHitRating()
        {
            return HitRating;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }

        public virtual int CalcDodgeRating()
        {

            return DodgeRating;

        }

        public virtual int CalcBonusLife()
        {
            return MaxLife;
        }
        
        public virtual int CalcLife()
        {
            return Life;
        }


    }//end class
}
