using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoltenCoreClassLibrary;

namespace TheMoltenCore
{
    class TheMoltenCore
    {

        static void Main(string[] args)
        {


            #region weapons and armor tables
            //first we need some default weapons to choose from
            Weapon defaultSword = new Weapon("placeholder - default sword", Rarity.Rare, 100, 200, 0, 0);//placeholder
            Weapon defaultBow = new Weapon("placeholder - default bow", Rarity.Rare, 100, 200, 0, 0);//placeholder
            Weapon defaultAxe = new Weapon("placeholder - default axe", Rarity.Rare, 100, 200, 0, 0); //placeholder
            Weapon defaultWand = new Weapon("placeholder-default wand", Rarity.Rare, 100, 200, 0, 0);//placeholder
            Weapon defaultStaff = new Weapon("placeholder-default staff", Rarity.Rare, 100, 200, 0, 0); //placeholder
            Weapon defaultDagger = new Weapon("placeholder-default Dagger", Rarity.Rare, 100, 200, 0, 0);//placeholder
            //end placeholder/starting weapons

            Weapon earthShaker = new Weapon("Earthshaker", Rarity.Epic, 175, 263, 8, 0);//loot from Magmadar
            Weapon auraStoneHammer = new Weapon("Aurastone Hammer", Rarity.Epic, 79, 162, 0, 250);//loot from Garr
            Weapon brutalityBlade = new Weapon("Brutality Blade", Rarity.Epic, 90, 168, 10, 0); //loot from Garr
            Weapon gutGoreRipper = new Weapon("Gutgore Ripper", Rarity.Epic, 63, 119, 1, 0); //loot from Garr
            Weapon thunderFury = new Weapon("Thunderfury, Blessed Blade of the Windseeker", Rarity.Legendary, 800, 1550, 20, 1000); //this is a Crated ONLY weapon
            Weapon blackFury = new Weapon("Blackfury", Rarity.Epic, 255, 400, 8, 300);//this is a crafted only weapon
            Weapon nightFall = new Weapon("Nightfall", Rarity.Epic, 550, 900, 5, 450);
            Weapon azureSongMageBlade = new Weapon("Azuresong Mageblade", Rarity.Epic, 64, 140, 5, 175);//loot from Golemagg
            Weapon staffOfDominance = new Weapon("Staff of Dominance", Rarity.Epic, 126, 205, 9, 0);//Loot from Golemagg
            Weapon shadowStrike = new Weapon("Shadowstrike", Rarity.Epic, 147, 221, 0, 0); //loot from Sulfuron Harbinger
            Weapon coreHoundTooth = new Weapon("Core Hound Tooth", Rarity.Epic, 77, 127, 12, 0);//loot from Majordomo Executus
            Weapon finklesLavaDredger = new Weapon("Finkle's Lava Dredger", Rarity.Epic, 155, 234, 0, 0);//loot from Majordomo Executus
            Weapon boneReaversEdge = new Weapon("Bonereaver's Edge", Rarity.Epic, 600, 750, 40, 0);//CRAFTING ONLY
            Weapon Rhok = new Weapon("Rhok'delar, Longbow of the Ancient Keepers", Rarity.Epic, 700, 950, 40, 0);

            

            //this weapon is just for testing
            Weapon testingWep = new Weapon("<GM WEAPON>", Rarity.Legendary, 100, 550, 50, 500);

            //end weapons, could add more later if needed.

            //first on list will be default armor
            Armor testingArmor = new Armor("<GM ARMOR>", Rarity.Legendary, 500, 10);
            Armor defaultArmor = new Armor("placeholder - default Armor", Rarity.Rare, 0, 0);
            //end default armor list

            Armor robeOfVolatilePower = new Armor("Robe of Volatile Power", Rarity.Epic, 300, 5); //loot from Lucifron
            Armor salamanderScalePants = new Armor("Salamander Scale Pants", Rarity.Epic, 850, 0); //loot from Lucifron
            Armor medallionOfSteadfastMight = new Armor("Medallion of Steadfast Might", Rarity.Epic, 0, 25);//loot from Magmadar
            Armor nightSlayerGLoves = new Armor("Nightslayer Gloves", Rarity.Epic, 100, 11);//loot from Gehennas
            Armor earthfuryGauntlets = new Armor("Earthfury Gauntlets", Rarity.Epic, 325, 8);//loot from Gehennas
            Armor lawbringerHelm = new Armor("Lawbringer Helm", Rarity.Epic, 500, 11);//loot from Garr
            Armor cenarionGloves = new Armor("Cenarion Gloves", Rarity.Epic, 379, 0); //loot from Shazzrah
            Armor giantstalkersGloves = new Armor("Giantstalker's Gloves", Rarity.Epic, 50, 12);//loot from Shazzrah
            Armor felheartShoulderPads = new Armor("Felheart Shoulder Pads", Rarity.Epic, 750, 3);//loot from Baron Geddon
            Armor robesOfProphecy = new Armor("Robes of Prophecy", Rarity.Epic, 1200, 1); //loot from Golemagg
            Armor LionheartHelm = new Armor("Lionheart Helm", Rarity.Epic, 1050, 10);//only available from crafting.
            Armor VestmentsoftheOracle = new Armor("Vestments of the Oracle", Rarity.Epic, 1100, 10);

            //end Armor, could add more later if needed.
            #endregion

            Hero hero1 = new Hero("TestingBot", 30, 5, 6500, 6500, Race.Orc, HeroClass.Shaman, "PlaceHolderTitle", testingWep, testingArmor);
            int lavaCores = 2; //used for crafted reagent
            int Score = 0;
            int additionalStartingLife = 0;
            int additionalBonusDodge = 0;
            int totalHealingPotions = 0;
            int leftBinding = 0;
            int rightBinding = 0;
            hero1.Life = hero1.MaxLife;

            bool start = true;
            do
            {
                Console.Title = "The Molten Core";
                //int origWidth = Console.WindowWidth;
                //int origheight = Console.WindowHeight;
                //int newWidth = origWidth + 50;
                //int newHeight = origheight + 10;
                //Console.WriteLine(newHeight);
                Console.SetWindowSize(180, 40);
                //   Console.WriteLine("Mighty Hero...This is a dark place...Welcome... to The Molten Core...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                MCTitle();
                //  Console.WriteLine("Brave Champion, do you wish to enter the Molten Core? Y | N ");
                //   string startGameAnswer = Console.ReadLine().ToLower();

                #region character creation

                Console.WriteLine("Please name your hero: ");
                string heroNameChoice = Console.ReadLine();
                hero1.Name = heroNameChoice;
                hero1.HeroTitle = ApplyTitle();
                Console.Clear();
                Console.WriteLine("Now Choose your Race:\n1) Human\n2) Dwarf\n3) Night Elf\n4) Gnome\n5) Orc\n6) Undead\n7) Tauren\n8) Troll");
                ConsoleKey raceChoice = Console.ReadKey(true).Key;
                switch (raceChoice)
                {
                    case ConsoleKey.D1:
                        hero1.HeroRace = Race.Human;
                        Console.Clear();

                        break;
                    case ConsoleKey.D2:
                        hero1.HeroRace = Race.Dwarf;
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        hero1.HeroRace = Race.NightElf;
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        hero1.HeroRace = Race.Gnome;
                        Console.Clear();
                        break;
                    case ConsoleKey.D5:
                        hero1.HeroRace = Race.Orc;
                        Console.Clear();
                        break;
                    case ConsoleKey.D6:
                        hero1.HeroRace = Race.Undead;
                        Console.Clear();
                        break;
                    case ConsoleKey.D7:
                        hero1.HeroRace = Race.Tauren;
                        Console.Clear();
                        break;
                    case ConsoleKey.D8:
                        hero1.HeroRace = Race.Troll;
                        Console.Clear();
                        break;
                }//end raceChoice switch

                Console.WriteLine("Choose your Class:\n1) Druid\n2) Hunter\n3) Mage\n4) Paladin\n5) Priest\n6) Rogue\n7) Shaman\n8) Warrior\n9) Warlock");
                ConsoleKey ClassChoice = Console.ReadKey(true).Key;
                switch (ClassChoice)
                {
                    case ConsoleKey.D1:
                        hero1.HeroClass = HeroClass.Druid;
                        Console.Clear();

                        break;
                    case ConsoleKey.D2:
                        hero1.HeroClass = HeroClass.Hunter;
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        hero1.HeroClass = HeroClass.Mage;
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        hero1.HeroClass = HeroClass.Paladin;
                        Console.Clear();
                        break;
                    case ConsoleKey.D5:
                        hero1.HeroClass = HeroClass.Priest;
                        Console.Clear();
                        break;
                    case ConsoleKey.D6:
                        hero1.HeroClass = HeroClass.Rogue;
                        Console.Clear();
                        break;
                    case ConsoleKey.D7:
                        hero1.HeroClass = HeroClass.Shaman;
                        Console.Clear();
                        break;
                    case ConsoleKey.D8:
                        hero1.HeroClass = HeroClass.Warrior;
                        Console.Clear();
                        break;
                    case ConsoleKey.D9:
                        hero1.HeroClass = HeroClass.Warlock;
                        Console.Clear();
                        break;
                }//end classChoice switch
                #endregion

                #region first encounter

                TrashMobs coreHoundDog1 = new TrashMobs("Core Hound Dog", 2000, 2000, 55, 10, 100, 300, "A mighty Beast, vicous but faithful to the firelord");
                Console.WriteLine("You and your guild file one by one into the first cavern of the molten core unsure as to what would come next" +
                    " and slowly in the darkness it emerges..");
                System.Threading.Thread.Sleep(1500);
                Console.Write("\nA massive creature with two heads, each equipped with a mouth filled with rows of flaming teeth.\n" +
                   "Its body is covered with armored hide and studded with bony spikes. A streak of flames runs down\nits spine from head to stubby tail." +
                    " Vicious but faithful to the Firelord....you've come across "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("The Core Hound\n");
                Console.ResetColor();

                bool actionLoop = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill core hound? Y | N");
                    Console.WriteLine("\n Choose your next move wisely:\n1.) Attack\n2.) Player Stats\n3.) Monster Stats\n4.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattleTrash(hero1, coreHoundDog1);
                            if (coreHoundDog1.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You Killed the {0}", coreHoundDog1.Name + "\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 100");
                                Score = Score + 100;
                                Console.WriteLine("Total Score: " + Score);
                                Console.ResetColor();
                                actionLoop = false;
                                start = false;
                            }
                            break;
                        //case ConsoleKey.D2:
                        //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                        //    break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            //Console.WriteLine(hero1);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(coreHoundDog1);
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", coreHoundDog1.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop);//end actionloop dowhile
                                     //hero1.EquippedWeapon = thunderFury;
                                     //hero1.MaxLife = 2500 + hero1.EquippedWeapon.BonusLife + hero1.EquippedArmor.BonusLife;
                                     //Console.WriteLine(hero1.MaxLife);
                                     //the above 3 lines do work, however i cannot figure out how to turn this into a method rather than hard coding it. 
                                     //hero1.EquippedWeapon = thunderFury;
                                     //hero1.MaxLife = hero1.MaxLife+500;
                                     //hero1.MaxLife = hero1.MaxLife + hero1.EquippedArmor.BonusLife + hero1.EquippedWeapon.BonusLife;
                                     //Console.WriteLine(hero1.MaxLife);

                //the above code is no longer of any use. saving for reference

                //hero1.MaxLife = CalcMaxLife(thunderFury, lawbringerHelm);
                //Console.WriteLine(hero1.MaxLife);
                //Console.WriteLine(hero1);
                //this code works.




                Console.WriteLine("\nYou have looted");
                lavaCores = RandomLavaCores();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(lavaCores + " LavaCores");
                Console.ResetColor();
                Console.WriteLine("\n\n");
                Console.WriteLine("You can use LavaCores to craft powerful items in the crafting menu, however use them wisely as these are a scarce material.\n");
                System.Threading.Thread.Sleep(6500);
                Console.Clear();

                #endregion
                #region first encounter afterfight Menu
                Console.WriteLine("Your guild needs time to rebuff and get Mana, you have just enough time to:\n\n1) Ask a priest for a Prayer of Fortitude buff\n2) Ask a druid for Mark of The Wild Buff\n3) Craft Items\n4) Get a minor Heal" +
                    " +750 Life\n\n");
                ConsoleKey userchoice2 = Console.ReadKey(true).Key;

                switch (userchoice2)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("You have recieved the Prayer of Fortitude buff (Max Life + 400)");
                        //hero1.MaxLife = hero1.MaxLife + 400;
                        additionalStartingLife = additionalStartingLife + 400;
                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                        System.Threading.Thread.Sleep(3000);
                        //Console.WriteLine("LavaCores: " + lavaCores); Do not know why this was here. perhaps this code was meant for another line. 
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("You have recieved the Mark of The Wild (Dodge Rating + 5");
                        additionalBonusDodge = additionalBonusDodge + 5;
                        hero1.DodgeRating = CalcBonusDodge(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalBonusDodge;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Crafting in The Molten Core requires the use of LavaCores. Choose an item below to craft:\n1) BlackFury (LavaCores Required:2)\n2) Nightfall (LavaCores Required: 4)\n3) Minor Healing Potion - Restores 500 life (LavaCores Required:1)\n");
                        ConsoleKey craftingSelection = Console.ReadKey(true).Key;
                        switch (craftingSelection)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("Current Weapon: " + hero1.EquippedWeapon + "\n\nBlackFury" + blackFury);
                                Console.WriteLine("\nCraft Blackfury? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                                ConsoleKey blackFuryCraft = Console.ReadKey(true).Key;
                                switch (blackFuryCraft)
                                {
                                    case ConsoleKey.Y:
                                        if (lavaCores >= 2)
                                        {
                                            lavaCores = lavaCores - 2;
                                            hero1.EquippedWeapon = blackFury;
                                            hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have Crafted the Blackfury.");
                                            Console.ResetColor();
                                            Console.WriteLine(hero1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nBlackfury requires 2 LavaCores to craft. Save them up to craft more powerful items");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case ConsoleKey.N:
                                        Console.WriteLine("Wise choice... saving up your lavaCores might come in handy.");
                                        break;
                                }
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("Current Weapon: " + hero1.EquippedWeapon + "\n\nNightfall" + nightFall);
                                Console.WriteLine("\nCraft Nightfall? Y| N");
                                ConsoleKey nightFallCraft = Console.ReadKey(true).Key;
                                switch (nightFallCraft)
                                {
                                    case ConsoleKey.Y:
                                        if (lavaCores >= 4)
                                        {
                                            lavaCores = lavaCores - 4;
                                            hero1.EquippedWeapon = nightFall;
                                            hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have Crafted the Nightfall.");
                                            Console.ResetColor();
                                            Console.WriteLine(hero1);
                                        }
                                        else if (lavaCores < 4)
                                        {
                                            Console.WriteLine("Nightfall requires 4 LavaCores to craft. Save them up to craft more powerful items");
                                            Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        }
                                        break;
                                    case ConsoleKey.N:
                                        Console.WriteLine("\nWise choice... saving up your lavaCores might come in handy.");
                                        break;
                                }
                                break;
                            case ConsoleKey.D3:
                                if (lavaCores >= 1)
                                {
                                    lavaCores = lavaCores - 1;
                                    totalHealingPotions = 1;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\nYou have crafted a Minor Healing Potion\n");
                                    Console.ResetColor();
                                    Console.WriteLine("You can use these potions while fighting powerful adversaries...but use them wisely as LavaCores are a scarce resource.\nMinor Healing Potion - Restores 500 Life");
                                    Console.WriteLine("Press any button to continue:");
                                    ConsoleKey continue2 = Console.ReadKey(true).Key;
                                    switch (continue2)
                                    {
                                        case ConsoleKey.Spacebar:
                                            break;
                                    }
                                }
                                else if (lavaCores < 1)
                                {
                                    Console.WriteLine("\nMinor Healing Potions require 1 lavacore to craft.");
                                }
                                break;

                        }
                        break;
                    case ConsoleKey.D4:
                        //Console.WriteLine("Healers in your raid have healed you for +750 Life");
                        //Console.WriteLine(hero1.Life);
                        //Console.WriteLine(hero1.MaxLife);
                        if (hero1.Life < hero1.MaxLife)
                        {
                            Console.WriteLine("Healers in your raid have healed you for +750 Life");
                            hero1.Life = hero1.Life + 750;

                        }
                        else if (hero1.Life >= hero1.MaxLife)
                        {
                            Console.WriteLine("You were already at full health, Pay ATTENTION! (Score: - 35)");
                            Score = Score - 35;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Total Score Decreased by - 35");
                            Console.WriteLine("Total Score: " + Score);
                            Console.ResetColor();
                        }
                        break;

                }
                #endregion

                #region second encounter
                //System.Threading.Thread.Sleep(3500);

                Console.Clear();
                Console.Write("Upon killing one of the core hound dogs you and your guild make you way into the first boss chamber....the chamber of ");Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("Lucifron.");Console.ResetColor();
                Console.WriteLine("\nLucifron is one of the four Flamewaker captains of Ragnaros the Firelord. Lucifron can be found watching over the enormous core hound\n" +
                    "Magmadar, Favored pet of Ragnaros.\n");

                //Console.Write("Upon killing one of the core hound dogs you and your guild make your way into the first boss chamber...the chamber of Lucifron.\nLucifron is one of the four flamewaker captains of Ragnaros the firelord.\n" +
                //    "Lucifron can be found watching over the enormous core hound Magmadar, favored pet of Ragnaros.\n\n");

                Console.WriteLine("Flamewakers are ruthless servants of Ragnaros. Little is known about flamewakers. They are creatures not purely of fire.\n" +
                    "They are fiery elementals, but their bodies are flesh and blood. A flamewaker has a humanoid torso with long muscular arms which rests\n" +
                    "on a serpentine body; the creature's elongated head has a distinctively demonic quality. Its body is mostly covered with yellow or red \n" +
                    "scales, though a broad strip of grayish scales runs from its chest down the front of its body. Thick spikes range from 1 to 3 feet long\n" +
                    "protrude from its shoulders, arms, and tail.\n");
                //Console.WriteLine(hero1);
                Boss lucifron = new Boss("Lucifron", 6000, 6000, 80, 25, 400, 499, "One of four flamewalker captains to the firelord Ragnaros");

                bool actionLoop2 = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill lucifron? Y | N");
                    Console.WriteLine("\n Choose your next move wisely: \n1.) Attack\n2.) Use Minor Healing Potion\n3.) Player Stats\n4.) Monster Stats\n5.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattle(hero1, lucifron);
                            if (lucifron.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You have defeated {0}\n", lucifron.Name + "\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 250");
                                Score = Score + 250;
                                Console.WriteLine("Total Score:" + Score + "\n");
                                Console.ResetColor();
                                actionLoop2 = false;
                                start = false;
                            }
                            break;
                        case ConsoleKey.D2:
                            //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                            if (totalHealingPotions > 0)
                            {
                                totalHealingPotions = totalHealingPotions - 1;
                                Console.WriteLine("You have used a Minor Healing Potion and restored 500 Life");
                                hero1.Life = hero1.Life + 500;
                                if (hero1.Life > hero1.MaxLife)
                                {
                                    hero1.Life = hero1.MaxLife;
                                }
                            }
                            else if (totalHealingPotions <= 0)
                            {
                                Console.WriteLine("You do not have any Minor Healing Potions. (Aquire these via Crafting)");
                            }
                            break;
                        case ConsoleKey.D3:
                            //Console.WriteLine(hero1);
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine(lucifron);
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", lucifron.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop2);//end actionloop dowhile


                Console.WriteLine("Lucifron has dropped: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Robe of Volatile Power\n\n");
                Console.ResetColor();
                Console.WriteLine("Make a selction:\n1)Equip Robe of Volatile Power(This will replace your current armor)\n2)Disenchant item into 2 LavaCores (this is permanent)\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Drop:");
                Console.ResetColor();
                Console.WriteLine(robeOfVolatilePower);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Current Armor:");
                Console.ResetColor();
                Console.WriteLine(hero1.EquippedArmor);
                ConsoleKey lucifronLootChoice = Console.ReadKey(true).Key;
                switch (lucifronLootChoice)
                {
                    case ConsoleKey.D1:
                        hero1.EquippedArmor = robeOfVolatilePower;
                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                        if (hero1.Life > hero1.MaxLife)
                        {
                            hero1.Life = hero1.MaxLife;
                        }
                        Console.Clear();
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("You have equipped the Robe of Volatile Power");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hero1);

                        Console.WriteLine("LavaCores: " + lavaCores);

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nYou have disenchanted the Robe of Volatile Power into 2 LavaCores");
                        lavaCores = lavaCores + 2;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Total LavaCores: " + lavaCores);
                        Console.ResetColor();
                        break;
                }
                System.Threading.Thread.Sleep(3500);
                Console.Clear();
                #endregion
                #region second encounter afterfight Menu
                Console.WriteLine("\nYour Guild mates have started complaining and are requesting a 5 minute BIO break, as the raid leader it is up to you to make a decision:\n1)Allow Bio Break (This will lower your overall Score but refill your Life)\n2)Push forward (because your hardcore: Score + 25)\n");
                ConsoleKey bioBreak1 = Console.ReadKey(true).Key;
                switch (bioBreak1)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Make a Selection:\n1) Eat food (restoring your health to full but lowering your Total Score)\n2) Craft");
                        ConsoleKey bioBreakMenu1 = Console.ReadKey(true).Key;
                        switch (bioBreakMenu1)
                        {
                            case ConsoleKey.D1:
                                //Console.Clear();
                                Console.WriteLine("\nYou take these few free moments to sit and eat which restores your health to full.(Total Score - 50)\n");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Your total score has dropped by -50");
                                Score = Score - 50;
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Total Score: " + Score);
                                Console.ResetColor();

                                hero1.Life = hero1.MaxLife;
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("\nCrafting in The Molten Core requires the use of LavaCores. Choose an item below to craft:\n1) Finkle's Lava Dredger (required 3 LavaCores)\n2) Lionheart Helm (Requires 5 LavaCores)\n3) Minor Healing Potion");
                                ConsoleKey craftingChoice2 = Console.ReadKey(true).Key;
                                switch (craftingChoice2)
                                {
                                    case ConsoleKey.D1:
                                        Console.WriteLine("Current Weapon: " + hero1.EquippedWeapon + "\n\nFinkle's Lava Dredger" + finklesLavaDredger);
                                        Console.WriteLine("\nCraft Finkle's Lava Dredger? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                                        ConsoleKey finklesLavaDredgerCraft = Console.ReadKey(true).Key;
                                        switch (finklesLavaDredgerCraft)
                                        {
                                            case ConsoleKey.Y:
                                                if (lavaCores >= 3)
                                                {
                                                    lavaCores = lavaCores - 3;
                                                    hero1.EquippedWeapon = finklesLavaDredger;
                                                    hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                                    if (hero1.Life > hero1.MaxLife)
                                                    {
                                                        hero1.Life = hero1.MaxLife;
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("\nYou have Crafted the Finkle's Lava Dredger.");
                                                    Console.ResetColor();
                                                    Console.WriteLine(hero1);
                                                }
                                                else if (lavaCores < 3)
                                                {
                                                    Console.WriteLine("\nFinkle's Lava Dredger requires 3 LavaCores to craft. Save them up to craft more powerful items");
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                                    Console.ResetColor();
                                                }
                                                break;
                                            case ConsoleKey.N:
                                                Console.WriteLine("Wise choice... saving up your lavaCores might come in handy.");
                                                break;
                                        }
                                        break;
                                    case ConsoleKey.D2:
                                        Console.WriteLine("Current Armor: " + hero1.EquippedArmor + "\n\nLionheart Helm" + LionheartHelm);
                                        Console.WriteLine("\nCraft Lionheart Helm? Y| N");
                                        ConsoleKey nightFallCraft = Console.ReadKey(true).Key;
                                        switch (nightFallCraft)
                                        {
                                            case ConsoleKey.Y:
                                                if (lavaCores >= 5)
                                                {
                                                    lavaCores = lavaCores - 5;
                                                    hero1.EquippedArmor = LionheartHelm;
                                                    hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                                    hero1.DodgeRating = CalcBonusDodge(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalBonusDodge;
                                                    if (hero1.Life > hero1.MaxLife)
                                                    {
                                                        hero1.Life = hero1.MaxLife;
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("\nYou have Crafted the Lionheart Helm.");
                                                    Console.ResetColor();
                                                    Console.WriteLine(hero1);
                                                }
                                                else if (lavaCores < 5)
                                                {
                                                    Console.WriteLine("Lionheart Helm requires 5 LavaCores to craft. Save them up to craft more powerful items");
                                                    Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                                }
                                                break;
                                            case ConsoleKey.N:
                                                Console.WriteLine("\nWise choice... saving up your lavaCores might come in handy.");
                                                break;
                                        }
                                        break;
                                    case ConsoleKey.D3:
                                        if (lavaCores >= 1)
                                        {
                                            lavaCores = lavaCores - 1;
                                            totalHealingPotions = 1;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\nYou have crafted a Minor Healing Potion\n");
                                            Console.ResetColor();
                                            Console.WriteLine("You can use these potions while fighting powerful adversaries...but use them wisely as LavaCores are a scarce resource.\nMinor Healing Potion - Restores 500 Life");
                                            Console.WriteLine("Press any button to continue:");
                                            ConsoleKey continue2 = Console.ReadKey(true).Key;
                                            switch (continue2)
                                            {
                                                case ConsoleKey.Spacebar:
                                                    break;
                                            }
                                        }
                                        else if (lavaCores < 1)
                                        {
                                            Console.WriteLine("\nMinor Healing Potions require 1 lavacore to craft.");
                                        }
                                        break;
                                }
                                break;
                        }

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nBio breaks are for chumps. You force your guild to push on without any breaks for now. ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Score = Score + 25;
                        Console.WriteLine("Your total score has increased by +25\nTotal Score: " + Score);
                        Console.ResetColor();
                        break;
                }
                #endregion
                Console.WriteLine("Press any button to continue:");
                ConsoleKey continue1 = Console.ReadKey(true).Key;
                switch (continue1)
                {
                    case ConsoleKey.Clear:
                        break;
                }

                #region Third Encounter
                Console.Clear();
                Boss Shazzrah = new Boss("Shazzrah", 6000, 6000, 35, 5, 400, 650, "One of four flamewaker captains to the firelord Ragnaros.");
                Console.WriteLine("Your guild is eager to progress onto the next boss within the Core, you guys enter a small dark gap in the cave walls and make your\n" +
                    "way through the sordid hall...unable to see, you use your hands and feet to guide yourselves through the cavern...");
                System.Threading.Thread.Sleep(4500);
                Console.WriteLine("\nfinally you see some light and the hall slowly opens up to a large cavern....you've discovered the lair of Shazzrah\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Shazzrah:");
                Console.ResetColor();
                Console.WriteLine("Shazzrah is one of the four Flamewaker captains loyal to Ragnaros. Of all the flamewakers who followed Ragnaros into the world \n" +
                    "of Azeroth, Shazzrah is the most talented in the realm of the arcane magic. Shazzrah guards one of the Runes(Rune of Mazj) Required to summon Ragnaros. ");
                //Shazzrah guards one of the Runes(Rune of Mazj) Required to summon Ragnaros. 

                bool actionLoop3 = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill lucifron? Y | N");
                    Console.WriteLine("\n Choose your next move wisely: \n1.) Attack\n2.) Use Minor Healing Potion\n3.) Player Stats\n4.) Monster Stats\n5.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattle(hero1, Shazzrah);
                            if (Shazzrah.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You have defeated {0}\n", Shazzrah.Name + "\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 250");
                                Score = Score + 250;
                                Console.WriteLine("Total Score:" + Score + "\n");
                                Console.ResetColor();
                                actionLoop3 = false;
                                start = false;
                            }
                            break;
                        case ConsoleKey.D2:
                            //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                            if (totalHealingPotions > 0)
                            {
                                totalHealingPotions = totalHealingPotions - 1;
                                Console.WriteLine("You have used a Minor Healing Potion and restored 500 Life");
                                hero1.Life = hero1.Life + 500;
                                if (hero1.Life > hero1.MaxLife)
                                {
                                    hero1.Life = hero1.MaxLife;
                                }
                            }
                            else if (totalHealingPotions <= 0)
                            {
                                Console.WriteLine("You do not have any Minor Healing Potions. (Aquire these via Crafting)");
                            }
                            break;
                        case ConsoleKey.D3:
                            //Console.WriteLine(hero1);
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine(Shazzrah);
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", Shazzrah.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop3);//end actionloop dowhile

                #endregion
                #region Third Encounter Afterfight


                Console.WriteLine("Shazzrah has dropped: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Giantstalker's Gloves\n\n");
                Console.ResetColor();
                Console.WriteLine("Make a selction:\n1)Equip Giantstalker's Gloves(This will replace your current armor)\n2)Disenchant item into 2 LavaCores (this is permanent)\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Drop:");
                Console.ResetColor();
                Console.WriteLine(giantstalkersGloves);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Current Armor:");
                Console.ResetColor();
                Console.WriteLine(hero1.EquippedArmor);
                ConsoleKey ShazzrahLootChoice = Console.ReadKey(true).Key;
                switch (ShazzrahLootChoice)
                {
                    case ConsoleKey.D1:
                        hero1.EquippedArmor = giantstalkersGloves;
                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                        if (hero1.Life > hero1.MaxLife)
                        {
                            hero1.Life = hero1.MaxLife;
                        }
                        Console.Clear();
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("You have equipped the Giantstalker's Gloves");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hero1);

                        Console.WriteLine("LavaCores: " + lavaCores);

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nYou have disenchanted the Giantstalker's Gloves into 2 LavaCores");
                        lavaCores = lavaCores + 2;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Total LavaCores: " + lavaCores);
                        Console.ResetColor();
                        break;
                }
                System.Threading.Thread.Sleep(3500);
                Console.Clear();
                #endregion
                #region fourth Encounter

                Console.WriteLine("Before you can rest and recover from your duel with Shazzarah your guild starts to hear some rumbling sounds that seem to be coming from above you...\n" +
                    "You look around and the sound goes quiet....");
                System.Threading.Thread.Sleep(4500);
                Console.WriteLine("\nAs soon as you start to sit to drink the ceiling up ahead collapses and you see before you a creature of gargantuan size...Your guild is being confronted by");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("lieutenant Garr\n");
                System.Threading.Thread.Sleep(6500);
                Console.ResetColor();
                //Console.WriteLine("Garr is a conglomerate lava elemental and Lieutenant to Ragnaros.\n");
                Console.WriteLine("Garr is one of the lieutenants of Ragnaros who carried out the betrayal of Lord Thunderaan, the Prince of Air and otherwise referred to as the 'Windseeker'.\n");
                Console.WriteLine("During the Elemental Sundering, Ragnaros sought to consume Thunderaan, and did so by having his two lieutenants, Baron Geddon and Garr perpetrate him.\n" +
                    "Thunderaan, caught off guard, was utterly destroyed. Ragnaros almost completely consumed Thunderaan's essence, and stored the rest within a talisman of elemental binding.\n");
                Console.WriteLine("Ragnaros cleaved this talisman into two equal pieces, to which he assigned Baron Geddon and Garr.\n");
                Console.WriteLine("Garr, like Baron Geddon, holds half of the Bindings of the Windseeker, which contains the remaining essence of Thunderaan, Prince of Air. ");
                Console.WriteLine("\n\nPress any key to continue:");
                ConsoleKey garrContinue = Console.ReadKey(true).Key;
                switch (garrContinue)
                {
                    case ConsoleKey.Spacebar:
                        break;
                }
                Console.Clear();
                Boss Garr = new Boss("Garr", 6000, 6000, 35, 5, 400, 650, "a conglomerate lava elemental and Lieutenant to Ragnaros.");
                TrashMobs earthElemental = new TrashMobs("Earth Elemental Guard", 1000, 1000, 15, 5, 100, 200, "A earth elemental guard loyal to Garr");
                bool actionLoop4 = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill lucifron? Y | N");
                    Console.WriteLine("\n Choose your next move wisely: \n1.) Attack\n2.) Use Minor Healing Potion\n3.) Player Stats\n4.) Monster Stats\n5.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattle(hero1, Garr);
                            if (Garr.Life <= 0 && earthElemental.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You have defeated {0}\n", Garr.Name + "\n");
                                rightBinding = rightBinding + 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 250");
                                Score = Score + 250;
                                Console.WriteLine("Total Score:" + Score + "\n");
                                Console.ResetColor();
                                actionLoop4 = false;
                                start = false;
                            }

                            if (earthElemental.Life >= 1)
                            {
                                Combat.DoBattleTrash(hero1, earthElemental);
                            }
                            else if (earthElemental.Life <= 0)
                            {
                                Console.WriteLine("The Elemental Guard has been defeated.");
                            }                     
                            break;
                        case ConsoleKey.D2:
                            //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                            if (totalHealingPotions > 0)
                            {
                                totalHealingPotions = totalHealingPotions - 1;
                                Console.WriteLine("You have used a Minor Healing Potion and restored 500 Life");
                                hero1.Life = hero1.Life + 500;
                                if (hero1.Life > hero1.MaxLife)
                                {
                                    hero1.Life = hero1.MaxLife;
                                }
                            }
                            else if (totalHealingPotions <= 0)
                            {
                                Console.WriteLine("You do not have any Minor Healing Potions. (Aquire these via Crafting)");
                            }
                            break;
                        case ConsoleKey.D3:
                            //Console.WriteLine(hero1);
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine(Garr);
                            Console.WriteLine(earthElemental);
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", Garr.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop4);//end actionloop dowhile
                #endregion
#region Fourth Encounter AfterFight

                Console.WriteLine("\nGarr has dropped: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("lawbringer Helm\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bindings of the Windseeker - 'The Right Half of Thunderaan's Eternal Prison'\n\n");
                Console.ResetColor();
                Console.WriteLine("Make a selction:\n1)Equip lawbringer Helm(This will replace your current armor)\n2)Disenchant item into 2 LavaCores (this is permanent)\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Drop:");
                Console.ResetColor();
                Console.WriteLine(lawbringerHelm);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Current Armor:");
                Console.ResetColor();
                Console.WriteLine(hero1.EquippedArmor);
                ConsoleKey GarrLootChoice = Console.ReadKey(true).Key;
                switch (GarrLootChoice)
                {
                    case ConsoleKey.D1:
                        hero1.EquippedArmor = lawbringerHelm;
                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                        if (hero1.Life > hero1.MaxLife)
                        {
                            hero1.Life = hero1.MaxLife;
                        }
                        Console.Clear();
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("You have equipped the Lawbringer Helm");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hero1);

                        Console.WriteLine("LavaCores: " + lavaCores);

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nYou have disenchanted the Lawbringer Helm into 2 LavaCores");
                        lavaCores = lavaCores + 2;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Total LavaCores: " + lavaCores);
                        Console.ResetColor();
                        break;
                }
                System.Threading.Thread.Sleep(3500);
                Console.Clear();
                #endregion


                Console.WriteLine("Your raids healers quickly heal your health to full incase of another ambush.\nThe scene is quiet and it seems as if you have a moment to:");
                hero1.Life = hero1.MaxLife;
                Console.WriteLine("\n1)Craft a Minor Healing Potion (1 LavaCores Required)\n2)strategize with the raid");
                ConsoleKey menu44 = Console.ReadKey(true).Key;
                switch (menu44)
                {
                    case ConsoleKey.D1:
                        lavaCores = lavaCores - 1;
                        totalHealingPotions = totalHealingPotions + 1;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou have crafted a Minor Healing Potion (+500 life)");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.D2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total points +100");
                        Score = Score + 100;
                        Console.WriteLine("Total Score: " + Score);
                        Console.ResetColor();
                        break;
                }

                System.Threading.Thread.Sleep(3500);

                #region Fifth Encounter
                Console.Clear();
                Console.WriteLine("Your raid has healed and recovered and pushes forward into the molten core getting closer and closer to Ragnaros\nit appears that the Firelords Chamber is just a little further away when you encounter the final guard.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Lieutenant Barron Geddon\n\n");
                Console.ResetColor();
                Console.WriteLine("Baron Geddon is one of the eldest of all fire elementals, and he served as Ragnaros’ right hand during the beginning of the war against the titans.\n" +
                    "During one of the first battles against the then-unknown titan attackers, Geddon was defeated and forced into a humiliating retreat.Ragnaros immediately demoted his\n" +
                    "commander, thinking that Geddon had been defeated by an inferior foe.\n");
                Console.WriteLine("Geddon was infuriated that a creature not purely of fire replaced him, a noble among the elementals. In an effort to regain his master’s faith, Baron Geddon\n" +
                    "planned the now legendary betrayal of Thunderaan the Windseeker. In the midst of a great battle, Geddon separated the massive lightning elemental from his allies, and together\n" +
                    "with Garr and Ragnaros, they ambushed the great elemental in an effort to steal his power.\n");

                Console.WriteLine("Thunderaan was a powerful foe, even to a powerful elemental such as Ragnaros, and the Firelord was unable to completely destroy him as he had hoped. The three did\n" +
                    "manage to seal the Windseeker away, and imprison his essence in the talisman known as the Bindings of the Windseeker.");



                Console.WriteLine("\n\nPress any key to continue:");
                ConsoleKey barronContinue = Console.ReadKey(true).Key;
                switch (barronContinue)
                {
                    case ConsoleKey.Spacebar:
                        break;
                }
                Console.Clear();
                Boss BarronGeddon = new Boss("Barron Geddon", 6000, 6000, 35, 5, 400, 650, "a conglomerate lava elemental and Lieutenant to Ragnaros.");
               
                bool actionLoop5 = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill lucifron? Y | N");
                    Console.WriteLine("\n Choose your next move wisely: \n1.) Attack\n2.) Use Minor Healing Potion\n3.) Player Stats\n4.) Monster Stats\n5.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattle(hero1, BarronGeddon);
                            if (BarronGeddon.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You have defeated {0}\n", BarronGeddon.Name + "\n");
                                leftBinding = leftBinding + 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 350");
                                Score = Score + 350;
                                Console.WriteLine("Total Score:" + Score + "\n");
                                Console.ResetColor();
                                actionLoop5 = false;
                                start = false;
                            }      
                            break;
                        case ConsoleKey.D2:
                            //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                            if (totalHealingPotions > 0)
                            {
                                totalHealingPotions = totalHealingPotions - 1;
                                Console.WriteLine("You have used a Minor Healing Potion and restored 500 Life");
                                hero1.Life = hero1.Life + 500;
                                if (hero1.Life > hero1.MaxLife)
                                {
                                    hero1.Life = hero1.MaxLife;
                                }
                            }
                            else if (totalHealingPotions <= 0)
                            {
                                Console.WriteLine("You do not have any Minor Healing Potions. (Aquire these via Crafting)");
                            }
                            break;
                        case ConsoleKey.D3:
                            //Console.WriteLine(hero1);
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine(BarronGeddon);
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", BarronGeddon.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop5);//end actionloop dowhile
                #endregion
                #region Fifth Encounter Afterfight

                Console.WriteLine("\nBarron Geddon has dropped: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Shadowstrike\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bindings of the Windseeker - 'The Left Half of Thunderaan's Eternal Prison'\n\n");
                Console.ResetColor();
                Console.WriteLine("Make a selction:\n1)Equip Shadowstrike(This will replace your current armor)\n2)Disenchant item into 2 LavaCores (this is permanent)\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Drop:");
                Console.ResetColor();
                Console.WriteLine(shadowStrike);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Current Armor:");
                Console.ResetColor();
                Console.WriteLine(hero1.EquippedArmor);
                ConsoleKey barronLootChoice = Console.ReadKey(true).Key;
                switch (barronLootChoice)
                {
                    case ConsoleKey.D1:
                        hero1.EquippedWeapon = shadowStrike;
                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                        if (hero1.Life > hero1.MaxLife)
                        {
                            hero1.Life = hero1.MaxLife;
                        }
                        Console.Clear();
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("You have equipped Shadowstrike");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hero1);

                        Console.WriteLine("LavaCores: " + lavaCores);

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nYou have disenchanted the Shadowstrike into 2 LavaCores");
                        lavaCores = lavaCores + 2;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Total LavaCores: " + lavaCores);
                        Console.ResetColor();
                        break;
                }
                System.Threading.Thread.Sleep(3500);
                Console.Clear();

                #endregion

                #region final Crafting Menu

                Console.WriteLine("Barron Geddon...a powerful foe...has been defeated. Do not get comfortable champion as Ragnaros the Firelord will not fall so easily.");
                Console.WriteLine("It is time to muster all the strength and magic of your raid...");
                Console.WriteLine("It is time to utilize the LavaCores you have been saving throughout the instance.\n\n");

                Console.WriteLine("Use your LavaCores now to craft Anything you can to better prepare for Ragnaros:");
                bool finalMenuLoop = true;
                do
                {

                    Console.Clear();
                    Console.WriteLine("Crafting Menu:\n1) Bonereaver's Edge (6 LavaCores Required)\n2) Rhok'delar, Longbow of the Ancient Keepers (6 LavaCores Required)\n3) Vestments of the Oracle (4 LavaCores Required)\n4) Salamander Scale Pants (4 LavaCores Required)");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("5)Thunderfury, Blessed Blade of the Windseeker   (This legendary blade requires both left and right Bindings of the Windseeker & 10 LavaCores");
                Console.ResetColor();
                ConsoleKey finalCraftingMenu = Console.ReadKey(true).Key;
                switch (finalCraftingMenu)
                {
                        
                    case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Current:");
                            Console.ResetColor();
                            Console.WriteLine(hero1.EquippedWeapon);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCraftable:");
                            Console.ResetColor();
                            Console.WriteLine(boneReaversEdge);
                            Console.WriteLine("\nCraft Bonereaver's Edge? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                            ConsoleKey bonereaverSelection = Console.ReadKey(true).Key;
                            switch (bonereaverSelection)
                            {
                                case ConsoleKey.Y:
                                    if (lavaCores >= 6)
                                    {
                                        lavaCores = lavaCores - 6;
                                        hero1.EquippedWeapon = boneReaversEdge;
                                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                        if (hero1.Life > hero1.MaxLife)
                                        {
                                            hero1.Life = hero1.MaxLife;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("You have Crafted the Bonereaver's Edge.");
                                        Console.ResetColor();
                                        Console.WriteLine(hero1);
                                        Console.WriteLine("Are you finished Crafting? Y | N");
                                        ConsoleKey finishedCrafting6 = Console.ReadKey(true).Key;
                                        switch (finishedCrafting6)
                                        {
                                            case ConsoleKey.Y:
                                                finalMenuLoop = false;
                                                break;
                                            case ConsoleKey.N:
                                                finalMenuLoop = true;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                                finalMenuLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nBonereaver's Edge requires 6 LavaCores to craft. Save them up to craft more powerful items");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        Console.ResetColor();
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Wise choice..");
                                    Console.WriteLine("Are you finished Crafting? Y | N");
                                    ConsoleKey finishedCrafting1 = Console.ReadKey(true).Key;
                                    switch (finishedCrafting1)
                                    {
                                        case ConsoleKey.Y:
                                            finalMenuLoop = false;
                                            break;
                                        case ConsoleKey.N:
                                            finalMenuLoop = true;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                            finalMenuLoop = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Current:");
                            Console.ResetColor();
                            Console.WriteLine(hero1.EquippedWeapon);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCraftable:");
                            Console.ResetColor();
                            Console.WriteLine(Rhok);
                            Console.WriteLine("\nCraft Rhok'delar, Longbow of the Ancient Keepers? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                            ConsoleKey rhokSelection = Console.ReadKey(true).Key;
                            switch (rhokSelection)
                            {
                                case ConsoleKey.Y:
                                    if (lavaCores >= 6)
                                    {
                                        lavaCores = lavaCores - 6;
                                        hero1.EquippedWeapon = Rhok;
                                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                        if (hero1.Life > hero1.MaxLife)
                                        {
                                            hero1.Life = hero1.MaxLife;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("You have Crafted Rhok'delar, Longbow of the Ancient Keepers.");
                                        Console.ResetColor();
                                        Console.WriteLine(hero1);
                                        Console.WriteLine("Are you finished Crafting? Y | N");
                                        ConsoleKey finishedCrafting7 = Console.ReadKey(true).Key;
                                        switch (finishedCrafting7)
                                        {
                                            case ConsoleKey.Y:
                                                finalMenuLoop = false;
                                                break;
                                            case ConsoleKey.N:
                                                finalMenuLoop = true;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                                finalMenuLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nRhok'delar, Longbow of the Ancient Keepers requires 6 LavaCores to craft. Save them up to craft more powerful items");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        Console.ResetColor();
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Wise choice..");
                                    Console.WriteLine("Are you finished Crafting? Y | N");
                                    ConsoleKey finishedCrafting2 = Console.ReadKey(true).Key;
                                    switch (finishedCrafting2)
                                    {
                                        case ConsoleKey.Y:
                                            finalMenuLoop = false;
                                            break;
                                        case ConsoleKey.N:
                                            finalMenuLoop = true;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                            finalMenuLoop = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    case ConsoleKey.D3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Current:");
                            Console.ResetColor();
                            Console.WriteLine(hero1.EquippedArmor);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCraftable:");
                            Console.ResetColor();
                            Console.WriteLine(VestmentsoftheOracle);
                            Console.WriteLine("\nCraft Vestments of the Oracle? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                            ConsoleKey vestmentsSelection = Console.ReadKey(true).Key;
                            switch (vestmentsSelection)
                            {
                                case ConsoleKey.Y:
                                    if (lavaCores >= 4)
                                    {
                                        lavaCores = lavaCores - 4;
                                        hero1.EquippedArmor = VestmentsoftheOracle;
                                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                        hero1.DodgeRating = CalcBonusDodge(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalBonusDodge;
                                        if (hero1.Life > hero1.MaxLife)
                                        {
                                            hero1.Life = hero1.MaxLife;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("You have Crafted Vestments of the Oracle.");
                                        Console.ResetColor();
                                        Console.WriteLine(hero1);
                                        Console.WriteLine("Are you finished Crafting? Y | N");
                                        ConsoleKey finishedCrafting8 = Console.ReadKey(true).Key;
                                        switch (finishedCrafting8)
                                        {
                                            case ConsoleKey.Y:
                                                finalMenuLoop = false;
                                                break;
                                            case ConsoleKey.N:
                                                finalMenuLoop = true;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                                finalMenuLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVestments of the Oracle requires 4 LavaCores to craft. Save them up to craft more powerful items");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        Console.ResetColor();
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Wise choice..");
                                    Console.WriteLine("Are you finished Crafting? Y | N");
                                    ConsoleKey finishedCrafting3 = Console.ReadKey(true).Key;
                                    switch (finishedCrafting3)
                                    {
                                        case ConsoleKey.Y:
                                            finalMenuLoop = false;
                                            break;
                                        case ConsoleKey.N:
                                            finalMenuLoop = true;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                            finalMenuLoop = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    case ConsoleKey.D4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Current:");
                            Console.ResetColor();
                            Console.WriteLine(hero1.EquippedArmor);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCraftable:");
                            Console.ResetColor();
                            Console.WriteLine(salamanderScalePants);
                            Console.WriteLine("\nCraft Salamander Scale Pants? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                            ConsoleKey salamanderSelection = Console.ReadKey(true).Key;
                            switch (salamanderSelection)
                            {
                                case ConsoleKey.Y:
                                    if (lavaCores >= 4)
                                    {
                                        lavaCores = lavaCores - 4;
                                        hero1.EquippedArmor = salamanderScalePants;
                                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                        hero1.DodgeRating = CalcBonusDodge(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalBonusDodge;
                                        if (hero1.Life > hero1.MaxLife)
                                        {
                                            hero1.Life = hero1.MaxLife;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("You have Crafted Salamander Scale Pants.");
                                        Console.ResetColor();
                                        Console.WriteLine(hero1);
                                        Console.WriteLine("Are you finished Crafting? Y | N");
                                        ConsoleKey finishedCrafting9 = Console.ReadKey(true).Key;
                                        switch (finishedCrafting9)
                                        {
                                            case ConsoleKey.Y:
                                                finalMenuLoop = false;
                                                break;
                                            case ConsoleKey.N:
                                                finalMenuLoop = true;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                                finalMenuLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nSalamander Scale Pants requires 4 LavaCores to craft. Save them up to craft more powerful items");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        Console.ResetColor();
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Wise choice..");
                                    Console.WriteLine("Are you finished Crafting? Y | N");
                                    ConsoleKey finishedCrafting4 = Console.ReadKey(true).Key;
                                    switch (finishedCrafting4)
                                    {
                                        case ConsoleKey.Y:
                                            finalMenuLoop = false;
                                            break;
                                        case ConsoleKey.N:
                                            finalMenuLoop = true;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                            finalMenuLoop = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                                    
                    case ConsoleKey.D5:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Current:");
                            Console.ResetColor();
                            Console.WriteLine(hero1.EquippedWeapon);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCraftable:");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(thunderFury);
                            Console.ResetColor();
                            Console.WriteLine("\nCraft Thunderfury, Blessed Blade of the Windseeker? Y| N\nnote: crafting a weapon or armor piece will equip that item and your old gear will be list.");
                            ConsoleKey thunderFurySelection = Console.ReadKey(true).Key;
                            switch (thunderFurySelection)
                            {
                                case ConsoleKey.Y:
                                    if (lavaCores >= 10 && leftBinding >= 1 && rightBinding >= 1)
                                    {
                                        lavaCores = lavaCores - 10;
                                        hero1.EquippedWeapon = thunderFury;
                                        hero1.MaxLife = CalcMaxLife(hero1.EquippedWeapon, hero1.EquippedArmor) + additionalStartingLife;
                                        if (hero1.Life > hero1.MaxLife)
                                        {
                                            hero1.Life = hero1.MaxLife;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You have Crafted Thunderfury, Blessed Blade of the Windseeker.");
                                        Console.ResetColor();
                                        Console.WriteLine(hero1);
                                        Console.WriteLine("Are you finished Crafting? Y | N");
                                        ConsoleKey finishedCrafting10 = Console.ReadKey(true).Key;
                                        switch (finishedCrafting10)
                                        {
                                            case ConsoleKey.Y:
                                                finalMenuLoop = false;
                                                break;
                                            case ConsoleKey.N:
                                                finalMenuLoop = true;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                                finalMenuLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThunderfury, Blessed Blade of the Windseeker requires 10 LavaCores to craft & both the Left and Right Bindings of the 'WindSeeker'.");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("You currently have " + lavaCores + " LavaCores...");
                                        Console.ResetColor();
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Wise choice..");
                                    Console.WriteLine("Are you finished Crafting? Y | N");
                                    ConsoleKey finishedCrafting5 = Console.ReadKey(true).Key;
                                    switch (finishedCrafting5)
                                    {
                                        case ConsoleKey.Y:
                                            finalMenuLoop = false;
                                            break;
                                        case ConsoleKey.N:
                                            finalMenuLoop = true;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection: Returning to Crafting Menu");
                                            finalMenuLoop = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    default:
                        Console.WriteLine("Invalid Selection: Try again.");
                        break;
                }
                } while (finalMenuLoop);

                #endregion
                #region Ragnaros Encounter
                Console.Clear();
                Console.WriteLine("You and your raid have become well equipped during your adventure throughout The Molten Core, but has it been enough?");
                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("\nYou and your raid have defeated the mighty guardians of Ragnaros the Firelord and have made your way into his Hallowed Chamber");
                Console.WriteLine("\nThe Chamber is a large open cavity deep within The Core, at the very center lies a vast bubbling pool of molten lava.....");
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("\nYour raid starts surrounding the giant pool of lava forming a circle of champions around it when suddenly the room begins to shake.\n" +
                    "The room is shaking vigorously as if the earth itself was cracking beneath you....Suddenly the ancient boss emerged from the center of the lava pool\n" +
                    "standing as tall as the tallest mountain...finally you are face to face with...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ragnaros the Firelord");
                Console.ResetColor();

                Boss Ragnaros = new Boss("Ragnaros the Firelord", 10000, 10000, 40, 20, 700, 1500, "The Ancient Legendary Elemental Lord of Fire - Ragnaros");


                bool actionLoop6 = true;
                do
                {

                    Console.WriteLine("\n" + hero1);
                    Console.WriteLine("LavaCores: " + lavaCores);
                    // Console.WriteLine("Attempt to kill core hound? Y | N");
                    Console.WriteLine("\n Choose your next move wisely:\n1.) Attack\n2.) Player Stats\n3.) Monster Stats\n4.) Exit Game");
                    ConsoleKey actionMenuChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (actionMenuChoice)
                    {
                        case ConsoleKey.D1:
                            Combat.DoBattle(hero1, Ragnaros);
                            if (Ragnaros.Life <= 0)
                            {
                                lavaCores = lavaCores + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You have defeated {0}", Ragnaros.Name + "\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Score + 100");
                                Score = Score + 100;
                                Console.WriteLine("Total Score: " + Score);
                                Console.ResetColor();
                                actionLoop6 = false;
                                start = false;
                               

                            }
                            Console.WriteLine("{0}",RagnarosYell());
                            break;
                        //case ConsoleKey.D2:
                        //    Console.WriteLine("PlaceHolder - run away goes here");//TODO figure out a mechanic for run away. do we even want a run away option?
                        //    break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            //Console.WriteLine(hero1);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(Ragnaros);
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("Thanks for playing The Molten Core");

                            actionLoop = false;
                            start = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You have chosen poorly. That was an improper selection");
                            break;
                    }//end actionMenuChoice switch
                    if (hero1.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou have been slain by {0}!\n", Ragnaros.Name);
                        Console.ResetColor();
                        Console.WriteLine("Final Score: " + Score);
                        Console.WriteLine("Thanks for playing The Molten Core");
                        actionLoop = false;
                        start = false;
                        Environment.Exit(0);
                    }

                } while (actionLoop6);

                #endregion
                Console.WriteLine("Continue: Y | N");
                ConsoleKey credits = Console.ReadKey(true).Key;
                switch (credits)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        Console.WriteLine("Mighty Champions\nYou have Braved The Molten Core and Defeated the mighty Ragnaros...You are truely...Heroes.");
                        System.Threading.Thread.Sleep(7500);
                        Console.Clear();
                        Console.WriteLine("Thanks for Playing:\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        MCTitle();
                        Console.ResetColor();
                        break;
                }













            } while (start);//very first do while loop




        }//end Main()


        public static void MCTitle()
        {
            Console.WriteLine(@"
        ____________________________________________________________________________________________________________________________________
        
        \__   __/|\     /|(  ____ \        (       )(  ___  )( \   \__   __/(  ____ \( (    /|        (  ____ \(  ___  )(  ____ )(  ____ \
           ) (   | )   ( || (    \/        | () () || (   ) || (      ) (   | (    \/|  \  ( |        | (    \/| (   ) || (    )|| (    \/
           | |   | (___) || (__            | || || || |   | || |      | |   | (__    |   \ | |        | |      | |   | || (____)|| (__    
           | |   |  ___  ||  __)           | |(_)| || |   | || |      | |   |  __)   | (\ \) |        | |      | |   | ||     __)|  __)   
           | |   | (   ) || (              | |   | || |   | || |      | |   | (      | | \   |        | |      | |   | || (\ (   | (      
           | |   | )   ( || (____/\        | )   ( || (___) || (____/\| |   | (____/\| )  \  |        | (____/\| (___) || ) \ \__| (____/\
           )_(   |/     \|(_______/        |/     \|(_______)(_______/)_(   (_______/|/    )_)        (_______/(_______)|/   \__/(_______/
        _____________________________________________________________________________________________________________________________________
                                                                                                                                  ");
            Console.ResetColor();

        }

        static string ApplyTitle()
        {

            string[] titles = {"<The Mighty>", "<The Wise>", "<The KingSlayer>", "<The Undead>", "<The Conqueror>", "<The Gladiator>", "<The Undying>", "<The Salty>", "<Of Ironforge>", "<Of Stormwind>", "<Of Darnassaus>",
            "<Of Orgrimmar>", "<Of The UnderCity>", "<Of Silvermoon>", "<Of Dalaran>", "<The Warrior>","<The Commander>", "<The Marshal>","<The Vanquisher>",
            "<The Immortal>", "<The Knight>", "<The KingsGuard>", "<The Noble>"};

            Random RandoTitle = new Random();
            int indexNmbrTitle = RandoTitle.Next(titles.Length);
            string bestowedTitle = titles[indexNmbrTitle];
            return bestowedTitle;
        }

        static int CalcMaxLife(Weapon weapon, Armor armor)
        {
            Hero hero1 = new Hero("TestingBot", 30, 5, 6500, 6500, Race.Orc, HeroClass.Shaman, "PlaceHolderTitle", weapon, armor);
            int MaxLife = 6500 + hero1.EquippedWeapon.BonusLife + hero1.EquippedArmor.BonusLife;
            return MaxLife;

        }

        static int CalcBonusDodge(Weapon weapon, Armor armor)
        {
            Hero hero1 = new Hero("TestingBot", 30, 5, 6500, 6500, Race.Orc, HeroClass.Shaman, "PlaceHolderTitle", weapon, armor);
            int dodgeRating = 5 + hero1.EquippedArmor.BonusDodgeRating;
            return dodgeRating;
        }
        static int RandomLavaCores()
        {
            int[] lavaCoreDrops = { 1, 2, 3, 4 };
            Random randoLavaCoreDrops = new Random();
            int indexNmbrLavaCore = randoLavaCoreDrops.Next(lavaCoreDrops.Length);
            int nmbrOfCoresDropped = lavaCoreDrops[indexNmbrLavaCore];
            return nmbrOfCoresDropped;
        }

        static string RagnarosYell()
        {
            string[] ragtalk = { "RAGNAROS: BY FIRE BE PURGED", "RAGNAROS: TASTE THE FLAMES OF SULFURON!", "RAGNAROS: DIE INSECTS!" };

            Random randoTalk = new Random();
            int indexNmbrTalk = randoTalk.Next(ragtalk.Length);
            string speech = ragtalk[indexNmbrTalk];
            return speech;
        }


    }//end class
}//end namespace
