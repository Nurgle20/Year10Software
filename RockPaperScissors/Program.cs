using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);
                string userChoice = UserTurn();
                string computerChoice = ComputerTurn();
                result = DetermineWinner(userChoice, computerChoice);
                GiveFeedback(result, userChoice, computerChoice);
                updateScores(result, ref userScore, ref computerScore);
                repeat = PlayAgain();
            }
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "   Computer: " + computerScore);
        }
        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice !="3" && choice !="4" && choice !="5")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.WriteLine("4: Lizard");
                Console.WriteLine("5: Spock");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                return "rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else if (choice == "3")
            {
                return "Scissors";
            }
            else if (choice == "4")
            {
                return "Lizard";
            }
            else
            {
                return "Spock";
            }
        }
        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else if (choice == 3)
            {
                return "Scissors";
            }
            else if (choice == 4)
            {
                return "Lizard";
            }
            else
            {
                return "Spock";
            }
        }
        private static string DetermineWinner(string user, string computer)
        {
            if (user == "Rock")
            {
                if (computer == "Rock")
                {
                    return "Draw";
                }
                else if (computer == "Paper")
                {
                    return "Lose";
                }
                else if (computer == "Scissors")
                {
                    return "Win";
                }
                else if (computer == "Lizard")
                {
                    return "Win";
                }
                else
                {
                    return "Lose";
                }
            }
            else if (user == "Paper")
            {
                if (computer == "Rock")
                {
                    return "Win";
                }
                else if (computer == "Paper")
                {
                    return "Draw";
                }
                else if (computer == "Scissors")
                {
                    return "Lose";
                }
                else if (computer == "Lizard")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }
            else if (user == "Scissors")
            {
                if (computer == "Rock")
                {
                    return "Lose";
                }
                else if (computer == "Paper")
                {
                    return "Win";
                }
                else if (computer == "Scissors")
                {
                    return "Draw";
                }
                else if (computer == "Lizard")
                {
                    return "Win";
                }
                else
                {
                    return "Lose";
                }
            }
            else if (user == "Lizard")
            {
                if (computer == "Rock")
                {
                    return "Lose";
                }
                else if (computer == "Paper")
                {
                    return "Win";
                }
                else if (computer == "Scissors")
                {
                    return "Lose";
                }
                else if (computer == "Lizard")
                {
                    return "Draw";
                }
                else
                {
                    return "Win";
                }
            }
            else
            {
                if (computer == "Rock")
                {
                    return "Win";
                }
                else if (computer == "Paper")
                {
                    return "Lose";
                }
                else if (computer == "Scissors")
                {
                    return "Win";
                }
                else if (computer == "Lizard")
                {
                    return "Lose";
                }
                else
                {
                    return "Draw";
                }
            } 
           
        }
        private static void GiveFeedback(string reault, string userChoice, string computerChoice)
        {
            Console.WriteLine(reault + "! The computer chose " + computerChoice + " and you chose " + userChoice);
        }
        private static bool PlayAgain()
        {
            string choice = "";
            while (choice != "1" && choice !="2")
            {
                Console.WriteLine("Play again? 1= Yes, 2 = No");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else if (result == "Lose")
            {
                computerScore++;
            }
        }
    }
}
