using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Player
    {
        //member variables
        int score;
        public int numberOfWins;
        public int currentSelection;
        public Player player1;
        public Player player2;
        public PlayerResults currentselection;

        public static List<string> gameGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        internal string name;
        private object player1reults;
        private object winner;
        private object loser;

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
       



        ///////////////////////////////////////////////
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
            PlayerResults();
        }
            

        public PlayRound ()
	{
            Console.Clear();
            PrepareGame;
            while (!isGameOver)
            {
                PlaySingleRound();
                isGameOver = GetIsGameOver();
                if (!isGameOver)
                {
                    GetAnyKeyToContinue();
                }
            }
           
        }
	}




        public PlayerResults()
        {
            int numberOfVariables = gameGestures.Count();
            int roundWinDeterminer = (numberOfVariables + player1.currentSelection - player2.currentSelection) % numberOfVariables;
            if (roundWinDeterminer == 0)
            {
                PlayResults();

            }
            else if (roundWinDeterminer % 2 == 1)
            {
                PlayResults();
                player1.numberOfWins++;
            }
            else
            {
                PlayResults();
                player2.numberOfWins++;
            }


            public void PlayResults()
            {

                bool BothTie = false;
                if (BothTie)
                {
                    Console.WriteLine("{0} and {1} Tie The Round.");
                }
                else
                {
                    Console.WriteLine("{0} Wins The Round!");

                }

            }


 }      }

























    