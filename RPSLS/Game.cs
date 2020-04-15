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
        public Player player1;
        public Player player2;
        //constructor
        public Game()
        {
            player1 = new Human();
        }
        //member methods
        public void RunGame()
        {
            DisplayRules();
            ChooseOpponent();
            player1.AssignGesture();
            player2.AssignGesture();
            //CompareGestures();
        }
        public void DisplayRules() //re-write or use list to populate?
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("You can choose a single player or multiplayer game.");
            Console.WriteLine("Each player picks one gesture per round: Rock, Paper, Scissors, Lizard, or Spock.");
            Console.WriteLine("A player wins the game with a best of three rounds.");
            Console.WriteLine("Each gesture can beat two other gestures:");
            Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock");
            Console.WriteLine("Rock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }
        public void ChooseOpponent()
        {
            Console.WriteLine("Please choose to play single player or multiplayer");
            string userInput = Console.ReadLine();  //necessary to get userinput? switch or do while

            switch (userInput)
            {
                case "Single Player":
                    Console.WriteLine("You have chosen to play against AI");
                    player2 = new AI();
                    break;
                case "Multiplayer":
                    Console.WriteLine("You have chosen to play against another human");
                    player2 = new Human();
                    break;
                case "single player":
                    Console.WriteLine("You have chosen a single player game against AI");
                    player2 = new AI();
                    break;
                case "multiplayer":
                    Console.WriteLine("You have chosen to play against another human");
                    player2 = new Human();
                    break;
                default:
                    Console.WriteLine("Please choose either Single Player or Multiplayer");
                    break;
            }
            //public void ChoosePlayer()
            //{
            //    string input;
            //    do
            //    {
            //        Console.WriteLine("Please choose single player or multiplayer game:");
            //    }    

            //}
        }

        
    }
}
