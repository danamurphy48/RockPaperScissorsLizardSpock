using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract public class Player
    {
        //member variables
        //public string name;
        public List<string> gestures;
        public string choice;
        public int score;

        //constructor
        public Player()
        {  
            gestures = new List<string>();
            PopulateGestureOptions();
        }

        //member methods
        public void PopulateGestureOptions()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }
        public void DisplayGestureOptions() //move to Game class
        {
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public virtual void AssignGesture()   //switch statement? do while? to prevent bad user data
        {
            //Console.WriteLine("Choose a gesture to perform: ");
            //choice = Console.ReadLine();    //switch statement
            Console.WriteLine("Choose a gesture to perform:");
            string userInput = Console.ReadLine();  //necessary to get userinput? switch or do while. How to get it to cycle back if default

            switch (userInput)
            {
                case "Rock":
                    Console.WriteLine("You have chosen Rock");
                    choice = "Rock";
                    break;
                case "Paper":
                    Console.WriteLine("You have chosen Paper");
                    choice = "Paper";
                    break;
                case "Scissors":
                    Console.WriteLine("You have chosen Scissors");
                    choice = "Scissors";
                    break;
                case "Lizard":
                    Console.WriteLine("You have chosen Lizard");
                    choice = "Lizard";
                    break;
                default:    ///////////////////// this didn't return back to top. Use do while?
                    Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock.");
                    break;
            }
        }
        public virtual void MakeGesture() //was I going to use this to validate user data in AssignGesture()?
        {

        }
    }
}
