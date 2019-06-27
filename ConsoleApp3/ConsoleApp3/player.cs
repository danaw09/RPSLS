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
        public string name;
        public int numberOfWins;
        int score;
        string gesture;

        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        //constuctor



        public void Player()
        {
            numberOfWins = 0;
        }


        //method

        // public abstract void gesture(List<string> gestures);

        //public abstract void 
    }
}
