using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rocks kill scissors and lizards.");
            Console.WriteLine("Paper covers rock and spock.");
            Console.WriteLine("Scissors kills lizards and paper.");
            Console.WriteLine("Lizards kill spock and papers.");
            Console.WriteLine("Spock kills rocks and scissors.");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many players will you have?");
            string userInput = Console.ReadLine();
            int numberOfHumanPlayers = int.Parse(userInput);
             

            }

        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers = 1)
            {
                Player HumanPlayer : new Player
                Player ComputerPlayer : new Player
               
            }
            
            else if (numberOfHumanPlayers = 2)
            {
              Player PlayerOne : new Player
              Player PlayerTwo: new Player
        
            }
            else
            {
                Console.WriteLine("Invalid input. 1 player or 2 players. Please.");   
            }
        

        
        
        }

        public void CompareGestures(Gesture playerOneGesture,Gesture playerTwoGesture)
        {
            //I kinda struggled here and with the player setup, hope I got it right.
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("Tie game, go again.");
            }
            else if ((playerOneGesture == "Rock" && playerTwoGesture == "scissors" or "lizard")
                     (playerOneGesture == "Paper" && playerTwoGesture == "Spock" or "Rock")
                     (playerOneGesture == "Scissors" && playerTwoGesture == "Lizard" or "Paper")
                     (playerOneGesture == "Lizard" && playerTwoGesture == "Paper" or "Spock")
                     (playerOneGesture == "Spock" && playerTwoGesture == "Rock" or "Scissors"))
            {
                Console.WriteLine("You win, go again?");
            }
            else
            {
                Console.WriteLine("You get nothing. You lose. Good day sir.");            
            }
                        
        }

        public void DisplayGameWinner()
        {
            //Admittedly I'm not 100% sure, but I might have accidentally covered it.
        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
