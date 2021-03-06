﻿using System;
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
            DisplayCurrentScore();
            DisplayGameWinner();
        }
        public void DisplayRules()
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
            bool validChoice = false;
            while (!validChoice)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Single Player":
                        Console.WriteLine("You have chosen to play against AI");
                        player2 = new AI();
                        validChoice = true;
                        break;
                    case "Multiplayer":
                        Console.WriteLine("You have chosen to play against another human");
                        player2 = new Human();
                        validChoice = true;
                        break;
                    case "single player":
                        Console.WriteLine("You have chosen a single player game against AI");
                        player2 = new AI();
                        validChoice = true;
                        break;
                    case "multiplayer":
                        Console.WriteLine("You have chosen to play against another human");
                        player2 = new Human();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Please choose either Single Player or Multiplayer");
                        validChoice = false;
                        break;
                }
            }
        }

        public void CompareGestures()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("Tie!");
            }
            else if (player1.choice == "Rock" && (player2.choice == "Scissors" || player2.choice == "Lizard"))
            {
                player1.score++;
                Console.WriteLine("Player One scored a point.");
            }
            else if (player1.choice == "Paper")
            {
                if(player2.choice == "Rock" || player2.choice == "Spock")
                {
                    player1.score++;
                    Console.WriteLine("Player One scored a point.");
                }
                else
                {
                    player2.score++;
                    Console.WriteLine("Player Two scored a point.");
                }
            }
            else if(player1.choice == "Scissors")
            {
                if(player2.choice == "Paper" || player2.choice == "Lizard")
                {
                    player1.score++;
                    Console.WriteLine("Player One scored a point.");
                }
                else
                {
                    player2.score++;
                    Console.WriteLine("Player Two scored a point.");
                }
            }
            else if (player1.choice == "Lizard")
            {
                if (player2.choice == "Spock" || player2.choice == "Paper")
                {
                    player1.score++;
                    Console.WriteLine("Player One scored a point.");
                }
                else
                {
                    player2.score++;
                    Console.WriteLine("Player Two scored a point.");
                }
            }
            else if (player1.choice == "Spock")
            {
                if(player2.choice == "Scissors" || player2.choice == "Rock")
                {
                    player1.score++;
                    Console.WriteLine("Player One scored a point.");
                }
                else
                {
                    player2.score++;
                    Console.WriteLine("Player Two scored a point.");
                }
            }
            else
            {
                player2.score++;
                Console.WriteLine("Player Two scored a point");
            }
        }

        public void DisplayCurrentScore()
        {
            while (player1.score < 3 && player2.score < 3)
            {
                player1.AssignGesture();
                player2.AssignGesture();
                CompareGestures();
                Console.WriteLine("Player One has a score of " + player1.score);
                Console.WriteLine("Player Two has a score of " + player2.score);
            }
        }
        public void DisplayGameWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player One wins!");
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("Player Two wins!");
            }
            Console.ReadLine();
        }
    }
}
