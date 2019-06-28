using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class player
    {
        //member variables
        int score;
        public int numberOfWins;
        public int currentSelection;



        public static List<string> gameGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        internal string name;

        public void DisplayPlayerMenu()
        {
            for (int i = 0; i < gameGestures.Count(); i++)
            {
                Console.Write(i);

                Console.Write(" = ");

                Console.Write(gameGestures[i]);

                if (i < gameGestures.Count() - 1)
                {
                    Console.ResetColor();
                    Console.Write("  |  ");
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n")


         public abstract void GameGestures(List<string> gameGestures);



        //constuctor














    }
}
