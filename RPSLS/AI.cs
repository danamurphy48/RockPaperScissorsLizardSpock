﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        //member variables
        Random random = new Random();
        //constructor
        public AI()
        {
            score = 0;
        }
        //member methods
        public override void AssignGesture()   
        {
            int randomNumber = random.Next(0, 4); 
            choice = gestures[randomNumber];
            Console.WriteLine("Player Two chose " + choice);
        }
    }
}
