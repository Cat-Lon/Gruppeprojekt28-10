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
        private static int playerWeaponDamage = 6;
        private static int playerHeadArmor;
        private static int playerChestArmor = 1;
        private static int playerFists;
        private static int playerTotalArmor = playerChestArmor + playerHeadArmor + playerFists;
        private static int gApple;
        private static int apple;
        private static int rApple;
        
        
        // Monster variables
        private static int MonsterHP;
        private static int MonsterStr;


        private static int playerExperience = 0;
        private static List<int> ExperienceList = new List<int> { 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115 };


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our game: ADVENTURE PALS\n");
            Menu();

        }

        static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You died");
            Environment.Exit(0);
        }

        //Initializes player stats. TODO Call in Menu somewhere. :D
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

        private static void AdventurePals()
        {//Episk tems sang          
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("             ______              ______   _   _   _______   _    _   ______    ______   _____              _        _____   ");
            Console.WriteLine("     /\\     |  __  | \\ \\    / / |  ____| | \\ | | |__   __| | |  | | |  __  \\  |  ____| |  __ \\    /\\      | |      / ____|  ");
            Console.WriteLine("    /  \\    | |  | |  \\ \\  / /  | |__    |  \\| |    | |    | |  | | | |__)  | | |__    | |__) |  /  \\     | |      | (___   ");
            Console.WriteLine("   / /\\ \\   | |  | |   \\ \\/ /   |  __|   | . ` |    | |    | |  | | |  _   /  |  __|   |  ___/  / /\\ \\    | |      \\___  \\  ");
            Console.WriteLine("  / ____ \\  | |__| |    \\  /    | |____  | |\\  |    | |    | |__| | | | \\ \\   | |____  | |     / ____ \\   | |____   ___) | ");
            Console.WriteLine(" /_/    \\_\\ |______/     \\/     |______| |_| \\_|    |_|    \\_____// |_|  \\_\\  |______| |_|    /_/    \\_\\  \\______  |_____/  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            ThemeBeeps();
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
            AdventurePals();
            Console.WriteLine("\n\nWelcome! what is your name? ");
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


                    NextStep();
                }
            }

        }

        static void NextStep()
        {
            bool choice;
            Console.WriteLine("Where would you like to go (west / north / east / south). You can also rest");
            do
            {
                choice = false;
                string input = Console.ReadLine();

                if (input.ToLower().Trim() == "west" || input.ToLower().Trim() == "w")
                {
                    Console.WriteLine("You go west");
                    AdventureObstacle();
                }
                else if (input.ToLower().Trim() == "north" || input.ToLower().Trim() == "n")
                {
                    Console.WriteLine("You go north");
                    AdventureObstacle();
                }
                else if (input.ToLower().Trim() == "south" || input.ToLower().Trim() == "s")
                {
                    Console.WriteLine("You go south");
                    AdventureObstacle();
                }
                else if (input.ToLower().Trim() == "east" || input.ToLower().Trim() == "e")
                {
                    Console.WriteLine("You go east");
                    AdventureObstacle();
                }

                else if (input.ToLower().Trim() == "rest")
                {
                    Console.WriteLine("You rest for a bit. Now would be a good time to eat.");
                    input = Console.ReadLine();
                    if (input.ToLower().Trim() == "eat")
                    {

                        Console.WriteLine("You have \n 1:" + gApple + " golden apples\n2:" + apple + " normal apples \n3:" + rApple + " rotten apples");
                        Console.WriteLine("What do you want to eat? (write number)");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            if (gApple > 0)
                            { 
                            Console.WriteLine("You eat a golden apple. You restore 50 HP!!!");
                            playerHP += 50;
                            gApple -= 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have any golden apples");
                            }
                        }
                        else if (input == "2")
                        {
                            if(apple > 0)
                            { 
                            Console.WriteLine("You eat a normal apple. You restore 10 hp");
                            playerHP += 10;
                            apple -= 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have any normal apples");
                            }
                        }
                        else if (input == "3")
                        {
                            if (rApple > 0)
                            { 
                            Console.WriteLine("You eat a rotten apple. It restores 2 hp :(");
                            playerHP += 2;
                            rApple -= 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have any rotten apples");
                            }
                        }
                        NextStep();
                    }
                }
                else
                {
                    Console.WriteLine("Please pick (west / north / east / south) or rest");
                    choice = true;
                }
            } while (choice);

        }

        static void AdventureObstacle() // Decides what the player runs in to next
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
            {
                MeetNPC();
            }
            else if (randomNumber == 2)
            {
                MonsterEncounter();
            }
            else if (randomNumber == 3)
            {
                GetChest();
            }

        }

        static void MeetNPC() // Random NPC that greets you
        {
            Console.WriteLine("On your path you meet someone, they seem friendly");
            Console.WriteLine("What do you want to say?");
            
            string input = Console.ReadLine();

            Console.WriteLine("You say: " + input);

            Random random = new Random();

            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("\n'Hello' the person said");
                    Console.WriteLine("Be wary on the Road here traveler. \nThere are rumors of some nasty looking creatures roaming araound");
                    dialogueOptions1();
                    break;

                case 2:
                    Console.WriteLine("\n'Hi' the person said");
                    Console.WriteLine("Take care on the road friend. \nThere is an equal chance of treasure and Monster ecounters out there");
                    dialogueOptions2();
                    break;

                case 3:
                    Console.WriteLine("\n'Sup' the person said");
                    Console.WriteLine("Carefull not to slip in the corpse of a creature back there as i did");
                    dialogueOptions3();
                    break;

                case 4:
                    Console.WriteLine("\n Waddup?!");
                    Console.WriteLine("You look like you could need some divine fucking juice");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HP has been restored. You gained 100 HP!");
                    playerHP += 100;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    Console.WriteLine("\nIdk what the fuck just happened");
                    Console.WriteLine("He says with a very confused look on his face");
                    Console.WriteLine("He doesn't seem to notice you as he walks past you...");
                    break;
            }

            NextStep();
        }
        private static void GetChest() //Prints a randomly selected piece of loot (for now)
        {
            Random rnd = new Random();
            int type = rnd.Next(1, 6);
            int quality = rnd.Next(1, 101);
            bool pResponse = false;
            bool equipCheck = true;
            int armor;
            int weaponDamage;
            ChestSound();
            Console.WriteLine("You have found a chest!\n Do you wish to open it? (y/n)");
            while (pResponse != true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    pResponse = true;
                    LootSound();
                    Console.WriteLine("You got!");
                    switch (type)
                    {
                        case 1: //Chestplates
                            if (quality >= 80)
                            {
                                Console.WriteLine("Terrions plate!");
                                int rStat = rnd.Next(1, 21);
                                armor = 25 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent Armor: {playerChestArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerChestArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality >= 45)
                            {
                                Console.WriteLine("Standard iron armor");
                                int rStat = rnd.Next(1, 11);
                                armor = 10 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent Armor: {playerChestArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerChestArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality < 45) {
                                Console.WriteLine("Leather Armor held together with staples and hope");
                                int rStat = rnd.Next(1, 6);
                                armor = 5 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent Armor: {playerChestArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerChestArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            break;
                        case 2: //weapons
                            if (quality >= 80)
                            {
                                Console.WriteLine("The Sword of Kalameet!");
                                int rStat = rnd.Next(1, 21);
                                weaponDamage = 25 + rStat;
                                Console.WriteLine($"Attack: {weaponDamage}\nCurrent Weapon Damage: {playerWeaponDamage}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerWeaponDamage = weaponDamage;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality >= 45)
                            {
                                Console.WriteLine("A sharp iron sword");
                                int rStat = rnd.Next(1, 11);
                                weaponDamage = 25 + rStat;
                                Console.WriteLine($"Attack: {weaponDamage}\nCurrent Weapon Damage: {playerWeaponDamage}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerWeaponDamage = weaponDamage;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality < 45)
                            {
                                Console.WriteLine("A broken straight sword");
                                int rStat = rnd.Next(1, 6);
                                weaponDamage = 5 + rStat;
                                Console.WriteLine($"Attack: {weaponDamage}\nCurrent Weapon Damage: {playerWeaponDamage}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerWeaponDamage = weaponDamage;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            break;

                        case 3: //apples 
                            if (quality >= 80)
                            {
                                Console.WriteLine("A golden apple!");
                                gApple++;
                                break;
                            }
                            else if (quality >= 45)
                            {
                                Console.WriteLine("A regular apple, quite tasty in fact!");
                                apple++;
                            }
                            else if (quality < 45)
                            {
                                Console.WriteLine("A worm infested apple... why would you ever eat this?");
                                rApple++;
                            }
                            break;
                        case 4: //helmets
                            if (quality >= 80)
                            {
                                Console.WriteLine("The Helm of Light!");
                                int rStat = rnd.Next(1, 21);
                                armor = 25 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent Armor: {playerHeadArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerHeadArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality >= 45)
                            {
                                Console.WriteLine("An Iron Helm");
                                int rStat = rnd.Next(1, 11);
                                armor = 25 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent armor: {playerHeadArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerHeadArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality < 45)
                            {
                                Console.WriteLine("A ragged piece of leather for your head");
                                int rStat = rnd.Next(1, 6);
                                armor = 5 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent armor: {playerHeadArmor}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerHeadArmor = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            break;
                        case 5: //gauntlets
                            if (quality >= 80)
                            {
                                Console.WriteLine("The Fists of God!");
                                int rStat = rnd.Next(1, 21);
                                armor = 25 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent Armor: {playerFists}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerFists = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality >= 45)
                            {
                                Console.WriteLine("Solid iron Gauntlets");
                                int rStat = rnd.Next(1, 11);
                                armor = 25 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent armor: {playerFists}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerFists = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            else if (quality < 45)
                            {
                                Console.WriteLine("Ragged leather gloves");
                                int rStat = rnd.Next(1, 6);
                                armor = 5 + rStat;
                                Console.WriteLine($"Armor: {armor}\nCurrent armor: {playerFists}");
                                Console.WriteLine("Do you want to equip it?\n(y/n)");
                                while (equipCheck)
                                {
                                    string equip = Console.ReadLine().ToLower();
                                    if (equip == "y")
                                    {
                                        playerFists = armor;
                                        equipCheck = false;
                                    }
                                    else if (equip == "n")
                                    {
                                        equipCheck = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("(y/n)");
                                    }
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Tell William that this happened. cause it's not supposed to");
                                break;
                    }
                    NextStep();
                }
                else if(userInput == "n")
                {
                    pResponse = true;
                    Console.WriteLine("aww okay :(");
                    NextStep();
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

            Random RandomMonster = new Random(); //Randomizer
            string[] MonsterList = { "Slime ", "Goblin ", "Orc " }; //Monster Array list

            while (isrunning1)
            {
                int i = RandomMonster.Next(0, MonsterList.Length);
                string Youmeet = MonsterList[i];

                if (Youmeet == "Slime ")
                {
                    EncounterSound();
                    SlimeArt();
                    Console.WriteLine("You Encounter a Slime");
                    MonsterSlime();
                }

                else if (Youmeet == "Goblin ")
                {
                    EncounterSound();
                    GoblinArt();
                    Console.WriteLine("You encounter a Goblin");
                    MonsterGoblin();
                }

                else if (Youmeet == "Orc ")
                {
                    EncounterSound();
                    OrcArt();
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


        /***********Battle Action Method*************/
        private static void BattleAction()
        {
            isrunningPlayer = true;
            Random random = new Random(); //number randomizer

            while (isrunningPlayer) //battle whileloop
            {
                bool isrunningMonster = true;

                int randomDmg = random.Next(1, playerWeaponDamage) * 2 + playerStrength; //randomly  picks a number between chosen range + varibles
                Console.Write("You do " + randomDmg + " amount of dmg");
                Console.WriteLine();

                if (MonsterHP < randomDmg) //Lower than varibel 
                {
                    EnemyKillSound();
                    Console.WriteLine("\nThe Monster lie Bleeding violently at your feet.");

                    playerExperience += 100;
                    
                    if(playerExperience > ExperienceList[playerLevel-1])
                    {
                        LevelUp();
                    }
                    GetChest();
                    isrunningPlayer = false;
                }

                if (MonsterHP == randomDmg) //Equal varibel 
                {
                    EnemyKillSound();
                    Console.WriteLine("\nThe Monster dies ");
                    isrunningPlayer = false;
                }

                else if (MonsterHP > randomDmg) //higher than varibel
                {
                    MonsterHP = (MonsterHP - randomDmg);
                    AttackSound();
                    Console.WriteLine("Monster has " + MonsterHP + " Hp left");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("You didnt kill it. \nMonster fights back");
                    Console.ReadLine();

                    //Monster Fights Back while loop
                    while (isrunningMonster)
                    {
                        int randomDmg2 = (random.Next(1, 6) * 2 + MonsterStr) / playerTotalArmor; //randomly  picks a number between chosen range + varibles
                        Console.Write("Monster do " + randomDmg2 + " amount of dmg");
                        Console.WriteLine();

                        if (playerHP < randomDmg2) //Lower than varibel 
                        {
                            EnemyKillSound();
                            Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at the Monsters feet ");
                            isrunningPlayer = false;
                            isrunningMonster = false;

                            GameOver();
                        }

                        else if (playerHP == randomDmg2) //Equal varibel 
                        {
                            EnemyKillSound();
                            Console.WriteLine("\nYou are Defeated ");
                            isrunningPlayer = false;
                            isrunningMonster = false;

                            GameOver();
                        }

                        else if (playerHP > randomDmg2) //Higher yhan varibel
                        {
                            playerHP = (playerHP - randomDmg2);
                            AttackSound();
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

        /***************** Attack Switch ********************/
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
                    RunAwaySound();
                    Console.WriteLine("You Run away");
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    NextStep();
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    AttackSwitch();
                    break;
            }
            return true;
        }

        /************************ Monster Art ************************/
        private static void SlimeArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("          //////////                     ");
            Console.WriteLine("       ///          //                   ");
            Console.WriteLine("   //                ///                 ");
            Console.WriteLine("    //////     `          // ///         ");
            Console.WriteLine("      //     <o>     /        /          ");
            Console.WriteLine("      //         ///       /   ////      ");
            Console.WriteLine("       /   ///// / // <O>>      ///      ");
            Console.WriteLine("       //          //     // ///         ");
            Console.WriteLine("        ///         ///////    //        ");
            Console.WriteLine("          ////       /         ///       ");
            Console.WriteLine("            //     // /     ///  //      ");
            Console.WriteLine("             /  ///   /////     //       ");
            Console.WriteLine("             ///        /////            ");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void GoblinArt()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("    ///////                                 ///////  ");
            Console.WriteLine("       // /////          /////        /////// //     ");
            Console.WriteLine("        //    //////   //     ////  //       //      ");
            Console.WriteLine("         //         //     \\  ///     </  //        ");
            Console.WriteLine("           ///      /       \\/           //         ");
            Console.WriteLine("              // /      \\o>   <O//    //            ");
            Console.WriteLine("                //// `                //             ");
            Console.WriteLine("                    //     -  //       /             ");
            Console.WriteLine("                      ///            //              ");
            Console.WriteLine("                         // /---V  //                ");
            Console.WriteLine("                         //      //                  ");
            Console.WriteLine("                            // //                    ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void OrcArt()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine("                  //////                     ");
            Console.WriteLine("              ////     //////                ");
            Console.WriteLine("            //                //             ");
            Console.WriteLine("      //  //   /___________//    //// //     ");
            Console.WriteLine("       /////      o     o        ////        ");
            Console.WriteLine("         //    --------------     //         ");
            Console.WriteLine("         ///         /\\           //        ");
            Console.WriteLine("          //       (   ))        //          ");
            Console.WriteLine("         // /\\             /\\      //      ");
            Console.WriteLine("        ///////////////////////       //     ");
            Console.WriteLine("         //                  //      //      ");
            Console.WriteLine("          //                         //      ");
            Console.WriteLine("           //                     //         ");
            Console.WriteLine("            ////////////////////             ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /************* Battle Sounds ************/
        //AttackSound Beeps
        static void AttackSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 350);   
        }

        //RunAwaySound beeps
        static void RunAwaySound()
        {
            Console.Beep(400, 200);
            Console.Beep(250, 250);
            Console.Beep(400, 300);
            Console.Beep(200, 500);
            
        }

        //EnemyKillSound Beeps
        static void EnemyKillSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 300);
            Console.Beep(650, 300);
            Console.Beep(750, 250);
            
        }

        static void EncounterSound()
        {
            Console.Beep(500, 400);
            Console.Beep(800, 300);
            Console.Beep(500, 400);
            Console.Beep(800, 300);
            Console.Beep(500, 300);
            Console.Beep(800, 200);
            
        }
        static void LootSound()
        {
            Console.Beep(500, 300);
            Console.Beep(800, 300);
            Console.Beep(750, 250);
            Console.Beep(750, 250);
            Console.Beep(800, 200);
            
        }
        static void ChestSound()
        {
            Console.Beep(500, 300);
            Console.Beep(800, 300);
            Console.Beep(850, 300);  
        }

        static void ThemeBeeps()
        {
            Console.Beep(200, 800);
            Console.Beep(200, 300);
            Console.Beep(200, 250);
            Console.Beep(250, 250);
            Console.Beep(200, 250);
            Console.Beep(250, 250);
            Console.Beep(200, 600);
            Console.Beep(250, 250);
            Console.Beep(200, 250);
            Console.Beep(250, 550);
            Console.Beep(280, 500);
            Console.Beep(300, 350);
            Console.Beep(200, 600);
        }

        /*****************Dialogue Options******************/
        static void dialogueOptions1()
        {
            Console.WriteLine("\nWhat do you say? \n1. Thank you friend \n2. Mind your own business");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("He Smiles politely at your response \nand move on with his journey");
                    break;
                case "2":
                    Console.WriteLine("He grunts at your response. \nClearly dissatisfied with your attitude");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
        }

        static void dialogueOptions2()
        {
            Console.WriteLine("\nWhat do you say? \n1. Thank you for the warning Friend... \n2. Hmph I dont need care im invinsible");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("He Smiles politely \nalways nice to help a fellow traveler");
                    break;
                case "2":
                    Console.WriteLine("He smirk at your response. \nShaking his head as he walks away");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
        }

        static void dialogueOptions3()
        {
            Console.WriteLine("\nWhat do you say? \n1. Thank you. Hope you are okay \n2. HA HA HA you Fool");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("'who me? yeah just wanted to give \nyou a headsup thats all' \nHe says as he walks on");
                    break;
                case "2":
                    Console.WriteLine("He clench his fist at you for a second. \nBut realize you are not worth the effort ");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
        }

    }
}
