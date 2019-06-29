using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Computer : player
    {
        //member variables
        public string myRandomNumber;


        public void ComputerPlayer()
        {
            this.name = "Computer";
        }


        public void DisplayGame()
        {
            
         VsMode();
         GetMode();
        PrepareGame();
        }


        public Random randomNumber = new Random();

      
        //constuctor
        public override void GetGesture()
        {
            currentSelection = randomNumber.Next(5);
           
        }



    }

          

}

