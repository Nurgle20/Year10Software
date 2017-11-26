using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ",welcome to my program!");
           

           

            string pick = "";
            while (pick != "3") ;
            Console.WriteLine("Press 1 for Rock Paper Scissors Lizard Spock:");
            Console.WriteLine("Press 2 for BabyBlackJack");
            Console.WriteLine("Press 3 to Class");

            if (pick == "1")
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
            else if (pick == "2")
            {

            }

            else
            {
                Person p = new Person("Sebastian", "Vogel", 17);
                p.Sit();
                p.Walk(100);
                p.Stand();
                p.Birthday();
                p.Walk(100);
                p.ChangeNamePrompt();
                p.PrintInfo();

                Console.ReadLine();
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
            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
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
            Console.WriteLine(reault + "! The compuer chose " + computerChoice + " and you chose " + userChoice);
        }
        private static bool PlayAgain()
        {
            string choice = "";
            while (choice != "1" && choice != "2")
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



    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool sitting;
        private int steps;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            sitting = true;
            steps = 0;
        }

        public void ChangeName(string firstName, string lastName, string age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }

        public void ChangeNamePrompt()
        {
            Console.WriteLine($"Name is currently {this.firstName} {this.lastName} and is {this.age} years old, enter new name.");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            this.firstName = firstName;
            this.lastName = lastName;
           
        }

        public void Walk(int steps)
        {
            if (sitting)
            {
                Console.WriteLine("You can't walk while you are sitting");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} just walked {steps} steps");
                this.steps += steps;
            }
        }

        public void Birthday()
        {
            age++;
        }

        public void PrintInfo()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently sitting" +
                                  $" and has taken {steps} steps.");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently standing" +
                                  $" and has taken {steps} steps.");
            }
        }

        public void Sit()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is already sitting");
            }
            else
            {
                sitting = true;
            }
        }

        public void Stand()
        {
            if (sitting)
            {
                sitting = false;
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is already standing");
            }
        }
    }

}