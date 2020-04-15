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

        //public void ChooseName()
        //{
        //    Console.WriteLine("Please enter a name");
        //    public string name = Console.ReadLine();
        //}
            

        public override void AssignGesture()    //could delete this
        {
            base.AssignGesture();
        }
    }
}
