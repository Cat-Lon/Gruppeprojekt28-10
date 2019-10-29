﻿using System;
using System.Threading;
using System.Collections.Generic;

namespace AdventurePals
{
    class Program
    {
        // Player variables
        private static string playerName;
        private static int playerHP = 0;
        private static int playerStrength;
        private static int playerLevel;
        
        // Monster variables
        private static int MonsterHP;
        private static int MonsterStr;


        private static int playerExperience = 0;
        private static List<int> ExperienceList = new List<int> { 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115 };


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our game: ADVENTURE PALS\n");
            Menu();
            MonsterEncounter();

        }

        //Initializes player stats. TODO Call in Menu somewhere.
        static void CreatePlayer(string name)
        {
            playerName = name;
            playerHP = 50;
            playerStrength = 5;
            playerLevel = 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCharacter creation complete!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Character Name: " + playerName);
            Console.WriteLine("Hitpoints: " + playerHP);
            Console.WriteLine("Strength: " + playerStrength);
            Console.WriteLine("Level: " + playerLevel + " You need " + ExperienceList[playerLevel-1] + " experience to level up");
        }



        static void LevelUp()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LEVEL UP. HVORDAN GØR HAN DET?!?! WOOOOOW!!");
            playerLevel++;
            playerStrength += 1;
            Console.WriteLine("du er nu level " + playerLevel);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static int PlayerAttack()
        {
            return playerStrength;
        }


        private static void Menu()
        {
            bool IsTrue = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose one of the following!");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (IsTrue)
            {
                Console.WriteLine("1: Play");
                Console.WriteLine("2: Options");
                Console.WriteLine("3: Credits");
                Console.WriteLine("4: Quit\n");
                string UsersChoice = Console.ReadLine();


                if (UsersChoice == "1" || UsersChoice == "Play")
                {
                    GameStart();
                    IsTrue = false;
                }
                else if (UsersChoice == "2" || UsersChoice == "Options")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nThere are no options just yet, but keep an eye out\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (UsersChoice == "3" || UsersChoice == "Credits")
                {
                    Console.WriteLine("\nProgrammers: \n");
                }
                else if (UsersChoice == "4" || UsersChoice == "Quit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nFarewell!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(700);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDon't be foolish, just pick one of the following!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        private static void GameStart()
        {
            bool IsTrue = true;
            string UserName = "";
            Console.WriteLine("\nWelcome to: ADVENTURE PALLS. what is your name? ");
            while (IsTrue)
            {
                UserName = Console.ReadLine();
                if (UserName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dont be foolish, tell me your name!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine($"\nNice to meet you " + UserName);
                    IsTrue = false;
                }
            }
            IsTrue = true;
            Console.WriteLine("\nWhat shall we call your character?\n");

            while (IsTrue)
            {
                string CharacterName = Console.ReadLine();

                if (CharacterName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Give me a valid name!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine($"\nGreat! Your character is called:\n" + CharacterName);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlease be patient, game will start shortly!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1900);
                    CreatePlayer(CharacterName); // Create character and set playname to the user input.
                    IsTrue = false;
                }
            }

        }

        static int AdventureObstacle() // Decides what the player runs in to next
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 5);

            return randomNumber;
        }

        static void MeetNPC() // Random NPC that greets you
        {
            Console.WriteLine("On your path you meet someone");

            Random random = new Random();

            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("'Hello' the person said");
                    break;

                case 2:
                    Console.WriteLine("'Hi' the person said");
                    break;

                case 3:
                    Console.WriteLine("'Sup' the person said");
                    break;

                default:
                    Console.WriteLine("Idk what the fuck just happened");
                    break;
            }
        }
        private static void GetChest() //Prints a randomly selected piece of loot (for now)
        {
            Random rnd = new Random();
            int type = rnd.Next(1, 6);
            int quality = rnd.Next(1, 4);
            bool pResponse = false;
            Console.WriteLine("You have found a chest!\n Do you wish to open it? (y/n)");
            while (pResponse != true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    pResponse = true;
                    Console.WriteLine("You got!");
                    switch (type)
                    {
                        case 1:
                            switch (quality)
                            {
                                case 1:
                                    Console.WriteLine("Terrions plate!");
                                    break;
                                case 2:
                                    Console.WriteLine("Standard iron armor");
                                    break;
                                case 3:
                                    Console.WriteLine("Leather Armor held together with glue and hope");
                                    break;
                            }
                            break;
                        case 2:
                            switch (quality)
                            {
                                case 1:
                                    Console.WriteLine("The Sword Of Kalameet!");
                                    break;
                                case 2:
                                    Console.WriteLine("A perfectly normal sword");
                                    break;
                                case 3:
                                    Console.WriteLine("A broken straight sword");
                                    break;
                            }
                            break;
                        case 3:
                            switch (quality)
                            {
                                case 1:
                                    Console.WriteLine("A golden apple!");
                                    break;
                                case 2:
                                    Console.WriteLine("A regular apple, quite tasty in fact!");
                                    break;
                                case 3:
                                    Console.WriteLine("A suspicious apple, it's a little dirty but probably still edible...");
                                    break;
                            }
                            break;
                        case 4:
                            switch (quality)
                            {
                                case 1:
                                    Console.WriteLine("The Head Of Cerberus!");
                                    break;
                                case 2:
                                    Console.WriteLine("A Standard-issue soldier helmet");
                                    break;
                                case 3:
                                    Console.WriteLine("This hat is not much more than just a piece of leather");
                                    break;
                            }
                            break;
                        case 5:
                            switch (quality)
                            {
                                case 1:
                                    Console.WriteLine("Gods Own Fists!");
                                    break;
                                case 2:
                                    Console.WriteLine("Decent iron gauntlets");
                                    break;
                                case 3:
                                    Console.WriteLine("Ragged leather gloves");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Tell William that this happened. cause it's not supposed to");
                                break;
                    }
                }
                else if(userInput == "n")
                {
                    pResponse = true;
                    Console.WriteLine("aww okay :(");
                }
                else
                {
                    Console.WriteLine("(y/n)");
                }
            }
        }

        /*********************Random Monster Ecounter Function*********************/
        static bool isrunning1 = true;
        static bool isrunningPlayer = true;

        static bool MonsterEncounter() //Array randomizer of Monster list
        {
            Console.WriteLine("You encounter a monster");

            Random RandomMonster = new Random();
            string[] MonsterList = { "Slime ", "Goblin ", "Orc " };

            while (isrunning1)
            {
                string message = Console.ReadLine();
                int i = RandomMonster.Next(0, MonsterList.Length);
                string Youmeet = MonsterList[i];

                if (Youmeet == "Slime ")
                {
                    Console.WriteLine("You Encounter a Slime");
                    MonsterSlime();
                }

                else if (Youmeet == "Goblin ")
                {
                    Console.WriteLine("You encounter a Goblin");
                    MonsterGoblin();
                }

                else if (Youmeet == "Orc ")
                {
                    Console.WriteLine("You encounter an Orc");
                    MonsterOrc();
                }

                else
                {
                    isrunning1 = false;
                }

                Console.ReadLine();

            }

            return true;
        }

        /*****************Monster Stats*********************/
        static bool MonsterSlime()
        {
            MonsterHP = 60;
            MonsterStr = 2;
            Console.WriteLine("The Slime Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            Console.WriteLine("\nThe Slime starts oozing towards you in a slow and STEADY PASTE");
            AttackSwitch();

            return true;
        }

        static bool MonsterGoblin()
        {
            MonsterHP = 30;
            MonsterStr = 3;
            Console.WriteLine("The Goblin Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            Console.WriteLine("\nThe Goblin thrusts at you in an angry frenzy");
            AttackSwitch();

            return true;
        }

        static bool MonsterOrc()
        {
            MonsterHP = 40;
            MonsterStr = 6;
            Console.WriteLine("The Orc Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            Console.WriteLine("\nThe Orc Looks at you with an Arrogant look as it stomps up to you");
            AttackSwitch();

            return true;
        }

        /*************Player battleStats********/
        private static void PlayerStats()
        {
            playerHP = 50;
            playerStrength = 5;

        }

        /***********Battle Action Method*************/
        private static void BattleAction()
        {
            Random random = new Random(); //number randomizer

            while (isrunningPlayer)
            {
                PlayerStats();

                while (isrunningPlayer)
                {
                    bool isrunningMonster = true;

                    int randomDmg = random.Next(1, 6) * 2 + playerStrength; // randomly  picks a number between chosen range
                    Console.Write("You do " + randomDmg + " amount of dmg");
                    Console.WriteLine();

                    if (MonsterHP < randomDmg) // Lower than varibel 
                    {
                        Console.WriteLine("\nThe Monster lie Bleeding violently at your feet.");

                        playerExperience += 100;
                        if(playerExperience > ExperienceList[playerLevel-1])
                        {
                            LevelUp();
                        }

                        isrunningPlayer = false;
                    }

                    if (MonsterHP == randomDmg) // Equal varibel 
                    {
                        Console.WriteLine("\nThe Monster dies ");
                        isrunningPlayer = false;
                    }

                    else if (MonsterHP > randomDmg) // higher than varibel
                    {
                        MonsterHP = (MonsterHP - randomDmg);

                        Console.WriteLine("Monster has " + MonsterHP + " Hp left");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("You didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Monster Fights Back
                        while (isrunningMonster)
                        {
                            int randomDmg2 = random.Next(1, 6) * 2 + MonsterStr; // randomly  picks a number between chosen range
                            Console.Write("Monster do " + randomDmg2 + " amount of dmg");
                            Console.WriteLine();

                            if (playerHP < randomDmg2) // Lower than varibel 
                            {
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at the Monsters feet ");
                                isrunningPlayer = false;
                                isrunningMonster = false;
                            }

                            else if (playerHP == randomDmg2) // Equal varibel 
                            {
                                Console.WriteLine("\nYou are Defeated ");
                                isrunningPlayer = false;
                                isrunningMonster = false;
                            }

                            else if (playerHP > randomDmg2)
                            {
                                playerHP = (playerHP - randomDmg2);

                                Console.WriteLine("You have " + playerHP + " Hp left");
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("It didnt kill you. \nFight back");
                                Console.ReadLine();
                                isrunningMonster = false;
                            }

                        }
                    }
                }
            }

        }

        /**************Attack Switch****************/
        static bool AttackSwitch()
        {
            Console.WriteLine("\nAttack? \nRunaway");

            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "attack":
                case "atk":
                    Console.WriteLine("\nYou attack");
                    BattleAction();
                    break;

                case "runaway":
                case "run":
                    Console.WriteLine("You Run away");
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    MonsterEncounter();
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    AttackSwitch();
                    break;
            }
            return true;
        }


    }
}
