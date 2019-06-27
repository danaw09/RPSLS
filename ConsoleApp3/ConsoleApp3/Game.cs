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
        int randomInt;
        player player1;
        player player2;
        int winGame = 2;

       



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

        public void  DisplayPlayerInface()
        {
            Console.WriteLine("hey there");
            Console.ReadLine();
           
        }
        public  void Rules()
        {
          
            Console.WriteLine("Hello and welcome to a new and challenging game\n");
            Console.WriteLine("RULES:");
           Console.WriteLine("This game is called rock, Paper, Scissors, lizard Spock from big bang theory,in each round, each player picks a variable by pressing keys 0-6:");
           
            Console.WriteLine("The winner of each round is the player who defeats the other.\nIn a tie, the process is repeated until a round winner is found.\nThe first player to achieve best of three wins the game.\n");
           
            Console.WriteLine("DURING EACH ROUND:");
          
            Console.WriteLine("Scissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock blunts Scissors");
            Console.ReadLine();
        }

       
        
        public void getPlayerResults()
        {
            if (player1.numberOfWins == 1)
            {
                Console.WriteLine( "p1 win");
            }
            else
            {
                Console.WriteLine("computer wins!");
            }
        }

    }
}
