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
     
        player player1;
        player player2;
        int winGame = 2;
        private string userinput;
        private readonly int gameMode;
        public string int32; 
      



        public PlayGame ()
	{
        while (ans != "NO")
            {
                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                string[] choices = new string[5] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string user = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + choices[n]);

                if (user == "ROCK" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "ROCK" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Computer wins");
                    count1 += 1;
                }
                else if (user == "PAPER" && choices[n] == "ROCK")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "PAPER" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "PAPER")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Same choices");
                }
                Console.WriteLine("Do u want to continue(YES/NO):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + count + " times");
            Console.WriteLine("Computer wins " + count1 + " times");
        }
    }
	}




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


        public string GetInput()
        {
            string userInput = Console.ReadKey(true).KeyChar.ToString();
            return userInput;
        }


        public string GetMode()
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
            //gameOver = false;

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
