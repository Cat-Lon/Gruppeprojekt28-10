using System;
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


        private int playerExperience;
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
            Console.WriteLine("du er nu level" + playerLevel);
        }

        static int PlayerAttack()
        {
            return playerStrength;
        }

       

        private static void Menu()
        {
            bool IsTrue = true;
            string UserName = "";
            Console.WriteLine("Please tell me your name: ");
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
                    Console.WriteLine($"\nHello there " + UserName);
                    IsTrue = false;
                }
            }

            IsTrue = true;
            Console.WriteLine("\nDo you want to play our game?");
            Console.WriteLine("y/n\n");

            while (IsTrue)
            {
                string UserAnswer = Console.ReadLine();

                if (UserAnswer == "y")
                {
                    Console.WriteLine("\nFantastic!\n");
                    IsTrue = false;
                }
                else if (UserAnswer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid answer!\nType y or n to continue!");
                }
            }
            IsTrue = true;
            Console.WriteLine("What shall we call your character?\n");

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

        static bool MonsterEncounter() //Array randomizer of Monster list
        {
            Console.WriteLine("You encounter a monster");

            Random RandomMonster = new Random();
            string[] MonsterList = { "Slime ", "Goblin ", "Orc "};

            while(isrunning1)
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

                
                switch (Youmeet) // Switch for deeper description of Monster encounter
                {
                    case "Slime ":
                        Console.WriteLine("The Slime starts oozing towards you in a slow and STEADY PASTE");
                    break;

                    case "Goblin ":
                        Console.WriteLine("The Goblin thrusts at you in an angry frenzy");
                    break;
                    
                    case "Orc ":
                        Console.WriteLine("The Orc Looks at you with an Arrogant look as it stomps up to you");
                    break;
                }                
            }

            return true;
        }

        /*****************Monster Stats*********************/
        static bool MonsterSlime()
        {
            MonsterHP = 60;
            MonsterStr = 2;
            Console.WriteLine("The Slime Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            return true;
        }

        static bool MonsterGoblin()
        {
            MonsterHP = 30;
            MonsterStr = 3;
            Console.WriteLine("The Goblin Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            return true;
        }

        static bool MonsterOrc()
        {
            MonsterHP = 40;
            MonsterStr = 6;
            Console.WriteLine("The Orc Got " + MonsterHP + " HP \nAnd a strength of " + MonsterStr);
            return true;
        }



    }
}
