using System;

namespace AdventurePals
{
    class Program
    {
        // Player variables
        private string playerName;
        int playerHP;
        int playerStrength;


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our game: ADVENTURE PALS\n");
            Menu();
        }

        //Initializes player stats. TODO Call in Menu somewhere.
        void CreatePlayer(string playerName)
        {
            this.playerName = playerName;
            this.playerHP = 50;
            this.playerStrength = 5;
        }

        int PlayerAttack()
        {
            return playerStrength;
        }

        private static void Menu()
        {
            bool IsTrue = true;
            Console.WriteLine("Please tell me your name: ");
            while (IsTrue)
            {
                string UserName = Console.ReadLine();
                if (UserName == "")
                {
                    Console.WriteLine("Dont be foolish, just tell me your name!\n");
                }
                else
                {
                    Console.WriteLine($"\nHello there " + UserName);
                    IsTrue = false;
                }
            }
            IsTrue = true;
            Console.WriteLine("\nDo you want to play?");
            Console.WriteLine("y/n");

            while (IsTrue)
            {
                string UserAnswer = Console.ReadLine();

                if (UserAnswer == "y")
                {
                    Console.WriteLine("Fantastic!");
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
        }

        static int AdventureObstacle() // Decides what the player runs in to next
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

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

    }
}
