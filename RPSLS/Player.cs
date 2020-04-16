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
        public void DisplayGestureOptions()
        {
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public abstract void AssignGesture();
    }
}
