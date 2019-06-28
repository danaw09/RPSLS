using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Human : player
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

        public override void GetGesture()
        {
            DisplayPlayerInterface();
            int userSelectionNumber;
            string userSelection = Console.ReadKey(true).KeyChar.ToString();
            if (!int.TryParse(userSelection, out userSelectionNumber) || !(userSelectionNumber >= 0) || !(userSelectionNumber <= 4))
            {
                Console.Clear();
                GetGesture();
            }
            else
            {
                currentSelection = userSelectionNumber;
            }



        }
    }
}
