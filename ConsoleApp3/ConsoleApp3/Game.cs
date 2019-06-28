using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Game
    {
        //member variables
        public bool gameOver;
        public bool TwoPlayerMode;
        int randomInt;
        player player1;
        player player2;
        int winGame = 2;
        private string userinput;
        private readonly int gameMode;









        //constuctor
        public void playerOne()
        {
            player1 = new player();
        }



        public void playerTwo()
        {
            player2 = new player();
        }
        //method



        public void DisplayGame()
        {
            Rules();

            VsMode();

            GetMode();

            GetUserInput();

            SetGameMode();
        }

        public void SetGameMode()
        {
            
                if (gameMode == 2)
                {
                    TwoPlayerMode = true;
                }
                else
                {
                    TwoPlayerMode = false;
                }
            
        }

        public void VsMode()
        {
            Console.Write("\nPress ");

            Console.Write("1");

            Console.Write(" for ");

            Console.Write("1-Player Mode");

            Console.Write(" or ");

            Console.Write("2");

            Console.Write(" for ");

            Console.WriteLine("2-Player Mode");
            Console.ReadLine();
        }

        public string GetUserInput()
        {
            string userInput = Console.ReadKey(true).KeyChar.ToString();
            return userInput;
        }


        public string GetMode()
        {
            string userInput = GetUserInput();
            if (!(userInput == "1" || userInput == "2"))
            {
                Console.Clear();
                return GetMode();

            }
            return (userInput);
        }
           
        


        public void Rules()
        {

            Console.WriteLine("Hello and welcome to Big Bang Theory inspired game\n");

            Console.WriteLine("RULES:");
          
            Console.WriteLine("DURING EACH ROUND:");

            Console.WriteLine("Scissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock blunts Scissors");
            Console.ReadLine();
            Console.Clear();
        }



       
        public void SetUpGame()
        {
            gameOver = false;

            player1 = new Human();

            if (TwoPlayerMode)
            {
                player2 = new Human
                {
                    name = "Player 2"
                };
            }
            else
            {
                player2 = new Computer();
            }

        }




        public void getPlayerResults()
        {
            if (player1.numberOfWins == 1)
            {
                Console.WriteLine("p1 win");
            }
            else
            {
                Console.WriteLine("computer wins!");
            }








   }    } 

}
