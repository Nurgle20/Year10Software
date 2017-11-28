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
            Console.ReadLine();

            string choice = "";
            while (choice != "4")
            {
                // Menu 
                Console.WriteLine("choose an Option:");
                Console.WriteLine("1. Rock Paper Scissors Lizard Spock");
                Console.WriteLine("2. BabyBlackJack");
                Console.WriteLine("3. Class");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    playRPS();
                }
                else if (choice == "2")
                {
                    playBBJ();
                }
                else if (choice == "3")
                {
                    playClass();
                }
                else
                {

                }

            }
        }

        private static void playClass()
        {
            Person p = new Person("Sebastian", "Vogel", 17);
            p.Sit();
            p.Walk(100);
            p.Stand();
            p.Birthday();
            p.Walk(100);
            p.ChangeName("Garion", "Vogel");
            p.ChangeNamePrompt();
            p.PrintInfo();

            Console.ReadLine();
        }

        #region Rock Paper Scissors
        private static void playRPS()
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
            Console.WriteLine(reault + "! The computer chose " + computerChoice + " and you chose " + userChoice);
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
        #endregion


        private static void playBBJ()
        {
            float money = 10;
            playGame(ref money);
        }
        #region BabyBlackJack
        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWin = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWin, betAmount, ref money);
            Menu(ref money);
        }

        private static float MakeBet(ref float money)
        {
            float betAmount = 0;
            bool validBet = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Dealer: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter your bet. you have $" + money);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("");

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > money)
                {
                    Console.WriteLine("Sorry, you do not have enough. Try again.");
                    validBet = false;
                }
                else if (betAmount < 0)
                {
                    Console.WriteLine("Sorry, you cannot bet a negative amount. Try again");
                    validBet = false;
                }
            }
            money = money - betAmount;
            return betAmount;
        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " drew " + card1 + " and " + card2 + " for a total of " + total);
            return total;
        }

        private static bool determineWinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("You Win!");
                return true;
            }
            else if (player < dealer)
            {
                Console.WriteLine("You Lose!");
                return false;
            }
            else
            {
                Console.WriteLine("It's a Draw! Dealer still Wins!");
                return false;
            }
        }

        private static void PayOut(bool playerWins, float betAmount, ref float money)
        {
            if (playerWins)
            {
                money = money + (betAmount * 2);
            }
        }

        private static void Menu(ref float money)
        {
            Console.Write("Would you like anthoer game? y/n: ");
            if (Console.ReadLine() == "y")
            {
                playGame(ref money);
            }
        }
        #endregion

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

        public void ChangeName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void ChangeNamePrompt()
        {
            Console.WriteLine($"Name is currently {this.firstName} {this.lastName}, enter new name.");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
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
    

        private static void playBBJ()
        {
            float money = 10;
            playGame(ref money);
        }
        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWin = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWin, betAmount, ref money);
            Menu(ref money);
        }

        private static float MakeBet(ref float money)
        {
            float betAmount = 0;
            bool validBet = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Dealer: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter your bet. you have $" + money);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("");

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > money)
                {
                    Console.WriteLine("Sorry, you do not have enough. Try again.");
                    validBet = false;
                }
                else if (betAmount < 0)
                {
                    Console.WriteLine("Sorry, you cannot bet a negative amount. Try again");
                    validBet = false;
                }
            }
            money = money - betAmount;
            return betAmount;
        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " drew " + card1 + " and " + card2 + " for a total of " + total);
            return total;
        }

        private static bool determineWinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("You Win!");
                return true;
            }
            else if (player < dealer)
            {
                Console.WriteLine("You Lose!");
                return false;
            }
            else
            {
                Console.WriteLine("It's a Draw! Dealer still Wins!");
                return false;
            }
        }

        private static void PayOut(bool playerWins, float betAmount, ref float money)
        {
            if (playerWins)
            {
                money = money + (betAmount * 2);
            }
        }

        private static void Menu(ref float money)
        {
            Console.Write("Would you like anthoer game? y/n: ");
            if (Console.ReadLine() == "y")
            {
                playGame(ref money);
            }
        }
    }

        

    




}