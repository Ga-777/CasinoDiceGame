using System;
namespace CasinoDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerBalance = 100;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to The Tops Casino");
            Console.WriteLine("|-|-|-|-|-|-|-|-|-|-|-|-|-|");
            Console.WriteLine("");
            Console.WriteLine("Please press enter to contiune: ");
            Console.ReadLine();
            Console.Clear();
            mainMenu(playerBalance);

        }
        static void mainMenu(int balance)
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Play Dice Game");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    playDiceGame(balance);
                    break;
                case "2":
                    viewBalance(balance);

                    break;
                case "3":

                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    mainMenu(balance);
                    break;
            }
        }
        static void playDiceGame(int balance)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Dice Game!");
            Console.WriteLine("Please enter your bet amount: ");
            int betAmount;
            while (!int.TryParse(Console.ReadLine(), out betAmount) || betAmount <= 0 || betAmount > balance)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid bet amount. Please enter a valid amount: ");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (balance <= 0)
            {



                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have no money left to bet. Please exit the game.");
                Console.ForegroundColor = ConsoleColor.Green;
                mainMenu(balance);
            }
            else if (betAmount >= 0 || betAmount < balance)
            {
                balance -= betAmount;
                Console.WriteLine($"You have bet {betAmount}. Your new balance is {balance}.");
                Console.WriteLine("");
                Console.WriteLine("Please press enter to pick your roll: ");
                Console.ReadLine();
                Console.Clear();

                Die Die1 = new Die();
                Die Die2 = new Die();

                Console.WriteLine("");
                Console.WriteLine("Pick your bet:");
                Console.WriteLine("|-|-|-|-|-|-|");
                Console.WriteLine("1. Bet on Doubles");
                Console.WriteLine();
                Console.WriteLine("2. Bet on not Doubles");
                Console.WriteLine();
                Console.WriteLine("3. Bet on Even sum");
                Console.WriteLine();
                Console.WriteLine("4. Bet on Odd sum");
                int betChoice;
                while (!int.TryParse(Console.ReadLine(), out betChoice) || betChoice < 1 || betChoice > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                if (betChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You have bet on Doubles.");
                    Console.WriteLine("Rolling the dice...");
                    Thread.Sleep(3000);
                    Die1.RollDie();
                    Die2.RollDie();
                    Die1.ColoredDie();
                    Die1.DrawRoll();
                    Die2.ColoredDie();
                    Die2.DrawRoll();
                    if (Die1.Roll == Die2.Roll)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You win!");
                        balance += betAmount * 2;
                        Console.WriteLine($"Your new balance is {balance}.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        mainMenu(balance);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lose!");
                        Console.WriteLine($"Your new balance is {balance}.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        mainMenu(balance);
                    }

                }
            }



        }
        static void viewBalance(int totalBalance)
        {

            Console.Clear();
            Console.WriteLine("Your balance is " + totalBalance.ToString("c"));
            Console.WriteLine("");
            Console.WriteLine("Please press enter to go back: ");
            Console.ReadLine();
            Console.Clear();
            mainMenu(totalBalance);








        }
    }
}
