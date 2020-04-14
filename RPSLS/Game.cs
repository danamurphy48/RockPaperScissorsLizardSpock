using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        public int humanScore;
        public int aiScore;
        public int humanTwoScore;
        //constructor

        //member methods
        public void RunGame()
        {
            //1. Display rules
            //2. 1 or 2 player?
            //3. 
        }
        public void DisplayRules() //re-write or use list to populate?
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("You can choose to play against another human or AI.");
            Console.WriteLine("Each player picks one gesture per round: Rock, Paper, Scissors, Lizard, or Spock.");
            Console.WriteLine("A player wins the game with a best of three rounds.");
            Console.WriteLine("Each gesture can beat two other gestures:");
            Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock");
            Console.WriteLine("Rock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.ReadLine();
        }
        public void ChooseOpponent()
        {
            Console.WriteLine("Please choose to play against AI or human");
            string userInput = Console.ReadLine();  //necessary to get userinput?
        }

        }
    }
}
