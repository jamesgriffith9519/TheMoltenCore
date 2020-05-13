using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{
   public class Armor
    {
        public string Name { get; set; }
        public Rarity ArmorRarity { get; set; }
        public int BonusLife { get; set; }
        public int BonusDodgeRating { get; set; }

        public Armor (string name, Rarity armorRarity, int bonusLife, int bonusDodgeRating)
        {
            Name = name;
            ArmorRarity = armorRarity;
            BonusLife = bonusLife;
            BonusDodgeRating = bonusDodgeRating;


        }

        //TODO need to figure out how to handle bonus life and bonus dodge rating

        public override string ToString()
        {
            return string.Format("Armor: {0}\nArmor Rarity: {1}\nBonus Life +{2}\nBonus Dodge Rating +{3}", Name, ArmorRarity, BonusLife, BonusDodgeRating);
        }










    }
}
