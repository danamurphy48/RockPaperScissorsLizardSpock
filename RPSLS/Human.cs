using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables

        //constructor
        public Human()
        {
            score = 0;
        }
        //member methods
        public override void AssignGesture()
        {
            Console.WriteLine("Choose a gesture to perform:");
            DisplayGestureOptions();
            bool validChoice = false;

            while (!validChoice)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Rock":
                        Console.WriteLine("You have chosen Rock");
                        choice = "Rock";
                        validChoice = true;
                        break;
                    case "Paper":
                        Console.WriteLine("You have chosen Paper");
                        choice = "Paper";
                        validChoice = true;
                        break;
                    case "Scissors":
                        Console.WriteLine("You have chosen Scissors");
                        choice = "Scissors";
                        validChoice = true;
                        break;
                    case "Lizard":
                        Console.WriteLine("You have chosen Lizard");
                        choice = "Lizard";
                        validChoice = true;
                        break;
                    case "Spock":
                        Console.WriteLine("You have chosen Spock");
                        choice = "Spock";
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock.");
                        validChoice = false;
                        break;
                }
            }
        }
    }
}
