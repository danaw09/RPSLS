using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Human: player
    {
        public Human()
        {
            this.name = "Player 1";
        }

        public void DisplayPlayerInterface()
        {
            Console.WriteLine(name + ": please make your selection:");
            Console.ReadLine();
        }
        //member variables

        //public override void Choose Gesture(List<strings> gestures);
        //constuc




        //method

    }
}
