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

        


    }
}
