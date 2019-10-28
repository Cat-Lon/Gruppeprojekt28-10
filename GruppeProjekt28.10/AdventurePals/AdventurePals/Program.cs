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
            Console.WriteLine("Welcome to our game: ADVENTURE PALS");
            menu();
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

        private static void menu()
        {
            Console.WriteLine("Welcome adventurer, please tell me your name: ");
        }

        


    }
}
