using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class player
    {
        //member variables
        int score;
        public int numberOfWins;
        public int currentSelection;
        public player player1;
        public  player player2;

        public static List<string> gameGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        internal string name;
        private object player1reults;

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
            Console.WriteLine("\n");
        }

        private void DisplayPlayerInterface()
        {
            Console.WriteLine(name + ": please make your selection:");
        }
        public abstract void GetGesture();

        
        private void PlaySingleRound()
        {
            player1.GetGesture();
            player2.GetGesture();
            player1.DisplayPlayerInterface();
            player2.DisplayPlayerInterface();
        }



        public player(player player1, player player2)
        {
            int numberOfVariables = gameGestures.Count();
            int roundWinDeterminer = (numberOfVariables + player1.currentSelection - player2.currentSelection) % numberOfVariables;
            if (roundWinDeterminer == 0)

        }

        public PlayResults()
        {

            if (player1reults = player1reults)
            {
                Console.ResetColor();
                Console.Write("  |  ");
            }
        }


        //constuctor

















    }
}
