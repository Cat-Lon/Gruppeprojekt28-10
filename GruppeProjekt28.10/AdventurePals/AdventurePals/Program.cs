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

        static int AdventureObstacle() // Decides what the player run in to next
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            return randomNumber;
        }
        private static void GetChest() //Prints a randomly selected piece of loot (for now)
        {
            Random rnd = new Random();
            int type = rnd.Next(1, 4);
            int quality = rnd.Next(1, 5);
            Console.WriteLine("You have found a chest!\n Do you wish to open it? (y/n)");
            string userinput = Console.ReadLine();
            if (userinput == "y")
            {
                switch (type)
                {
                    case 1:
                        switch (quality)
                        {
                            case 1:
                                Console.WriteLine("Top notch armor laddie");
                                break;
                            case 2:
                                Console.WriteLine("Not too shabby armor");
                                break;
                            case 3:
                                Console.WriteLine("This armor is held together with glue and hope");
                                break;
                        }

                        break;
                    case 2:
                        switch (quality)
                        {
                            case 1:
                                Console.WriteLine("This sword is a perfect tool for killing");
                                break;
                            case 2:
                                Console.WriteLine("A perfectly normal sword");
                                break;

                            case 3:
                                Console.WriteLine("This sword won't be doing you much good");
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
                                Console.WriteLine("A suspicious apple, it's a little dirty but probably still edible");
                                break;
                        }
                        break;
                    case 4:
                        switch (quality)
                        {
                            case 1:
                                Console.WriteLine("A legendary helmet!");
                                break;
                            case 2:
                                Console.WriteLine("Standard issue soldier helmet");
                                break;
                            case 3:
                                Console.WriteLine("This hat is not much more than just a piece of leather");
                                break;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("aww okay :(");
            }
        }

    }
}
