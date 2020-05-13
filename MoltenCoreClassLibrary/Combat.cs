using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenCoreClassLibrary
{
   public class Combat : Character
    {

        public static void DoAttack(Character attacker, Character defender)
        {

            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(50);
            if (diceRoll <= attacker.CalcHitRating() - defender.CalcDodgeRating())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} Missed", attacker.Name);
            }





        }//end DoAttack()
        //public static void DoAttackRagnaros(Character attacker, Character defender)
        //{

        //    Random rand = new Random();
        //    int diceRoll = rand.Next(1, 101);
        //    System.Threading.Thread.Sleep(50);
        //    if (diceRoll <= attacker.CalcHitRating() - defender.CalcDodgeRating())
        //    {
        //        int damageDealt = attacker.CalcDamage();
        //        defender.Life -= damageDealt;
        //        Console.ForegroundColor = ConsoleColor.DarkRed;
        //        Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
        //        Console.ResetColor();
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} Missed", attacker.Name);
        //    }





        //}//end DoAttackRagnaros()
        //public static void DoBattleRagnaros(Hero hero, Boss boss)
        //{

        //    DoAttackRagnaros(hero, boss);
        //    if (boss.Life > 0)
        //    {
        //        DoAttackRagnaros(boss, hero);
        //    }

        //}//end DoBattleRagnaros()

        public static void DoBattle(Hero hero, Boss boss)
        {

            DoAttack(hero, boss);
            if (boss.Life > 0)
            {
                DoAttack(boss, hero);
            }

        }//end DoBattle()

        public static void DoBattleTrash(Hero hero, TrashMobs trashmobs)
        {

            DoAttack(hero, trashmobs);
            if (trashmobs.Life > 0)
            {
                DoAttack(trashmobs, hero);
            }

        }//end DoBattle()















    }//end class Combat
}//end namespace
