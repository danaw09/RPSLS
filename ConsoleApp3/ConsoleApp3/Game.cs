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
     
        public bool TwoPlayerMode;
     
       public string player1;
        public string player2;
       
        private string userinput;
        private readonly int gameMode;
        public string int32; 
      

        public void DisplayGame()
        {
            
         VsMode();
         GetMode();
        PrepareGame();
        }

        
        

    }
}




     
        public void playerOne()
        {
          player1 = new player();
        }



        public void playerTwo()
        {
            player2 = new player();
        }
       


            
        

        public void PlayGameRounds()
        {
            Console.Clear();
            PrepareGame();
            
        }
        public void SetGameMode()
        {       PlayGameRounds();
            
                if (gameMode == 2)
                {
                    TwoPlayerMode = true;
                }
                else
                {
                    TwoPlayerMode = false;
                }
                Console.ReadLine();
            
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


        public void GetInput()
        {
            string userInput = Console.ReadKey(true).KeyChar.ToString();
            return userInput;
        }


        public void GetMode()
        {
            string userInput = userInput;
            if (!(userInput == "1" || userInput == "2"))
            {
                Console.Clear();
                return GetMode();

            }
            return Int32(userInput);
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



       
        public void PrepareGame()
        {
           

            player1 = new Human();

            if (TwoPlayerMode)
            {
                player2 = new Human();
                {
                    name = "Player 2";
                };
            }
            else
            {
                player2 = new Computer();
            }
            Console.Clear();
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



            




         } 


