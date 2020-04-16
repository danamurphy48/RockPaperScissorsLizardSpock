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
        public bool validChoice;

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
        public void DisplayGestureOptions() //move to Game class. Not sure if I've used this - could delete
        {
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public virtual void AssignGesture()   //switch statement? do while? to prevent bad user data
        {
            Console.WriteLine("Choose a gesture to perform:");
            DisplayGestureOptions();
            bool validChoice = false;

            while (!validChoice)
            {
                string userInput = Console.ReadLine();
                switch (userInput)  //necessary to have the console write lines?
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
                    default:    ///////////////////// this didn't return back to top. Use do while?
                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock.");
                        validChoice = false; //need option to change userInput. instantiate? new string userInput = Console.ReadLine()
                        break;
                }
            }

            ////Console.WriteLine("Choose a gesture to perform: ");
            ////choice = Console.ReadLine();    //switch statement
            //Console.WriteLine("Choose a gesture to perform:");
            //DisplayGestureOptions();//while loop + switch, or figure out do while?
            //string userInput = Console.ReadLine();  //necessary to get userinput? switch or do while. How to get it to cycle back if default
            //while (userInput != choice)
            //{
            //    switch (userInput)  //necessary to have the console write lines?
            //    {
            //        case "Rock":
            //            Console.WriteLine("You have chosen Rock");
            //            choice = "Rock";
            //            break;
            //        case "Paper":
            //            Console.WriteLine("You have chosen Paper");
            //            choice = "Paper";
            //            break;
            //        case "Scissors":
            //            Console.WriteLine("You have chosen Scissors");
            //            choice = "Scissors";
            //            break;
            //        case "Lizard":
            //            Console.WriteLine("You have chosen Lizard");
            //            choice = "Lizard";
            //            break;
            //        case "Spock":
            //            Console.WriteLine("You have chosen Spock");
            //            choice = "Spock";
            //            break;
            //        default:    ///////////////////// this didn't return back to top. Use do while?
            //            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock.");
            //            string result = Console.ReadLine(); //need option to change userInput. instantiate? new string userInput = Console.ReadLine()
            //            break;
            //    }
            //}
        }
        //public virtual void MakeGesture() //was I going to use this to validate user data in AssignGesture()?
        //{
        //    //Console.WriteLine("Choose a gesture to perform: ");
        //    //choice = Console.ReadLine();    //switch statement

        //}
    }
}
