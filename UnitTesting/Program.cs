using System;

namespace UnitTesting
{
    public class Program
    {
        //Initial balance is a global variable
        static public decimal Balance = 100.00M;


        static void Main(string[] args)
        {
            Options();
        }

        public static decimal ViewBalance(decimal balance)
        {
            Balance = balance;
            Console.WriteLine("Your current balnce is: " + balance);
            return Balance;
        }

        public static decimal Withdraw(decimal withdrawAmount, decimal inBalance)
        {
            inBalance -= withdrawAmount;
            Balance = inBalance;
            return Balance;
        }

        public static decimal Deposit(decimal depositAmount, decimal inBalance)
        {
            inBalance += depositAmount;
            Balance = inBalance;
            return Balance;
        }

        public static void BadEntery()
        {
            Console.WriteLine("Bad Entery. Restarting.");
            Options();
        }

        public static void Options()
        {
            Console.WriteLine("Enter a command: view balance, withdraw, deposit, exit");
            string input = Console.ReadLine();
            if (input != "exit")
            {
                if (input == "view balance")
                {
                    ViewBalance(Balance);
                    Console.WriteLine();
                    Options();
                }

                else if (input == "withdraw")
                {
                    Console.WriteLine("Your balance is: {0}", Balance);
                    Console.WriteLine("How much would you like to withdraw?");
                    string inputString = Console.ReadLine();
                    decimal withdrawInput = Convert.ToDecimal(inputString); 
                    if(withdrawInput > Balance)
                    {
                        Console.WriteLine("Insufficent funds. Please try again.");
                        Console.WriteLine();
                        Options();
                    }
                    Withdraw(withdrawInput, Balance);
                    Console.WriteLine("New blance: " + Balance);
                    Console.WriteLine();
                    Options();
                }

                else if (input == "deposit")
                {
                    Console.WriteLine("Your balance is: {0}", Balance);
                    Console.WriteLine("How much would you like to deposit?");
                    string inputString = Console.ReadLine();
                    decimal depositInput = Convert.ToDecimal(inputString);
                    Deposit(depositInput, Balance);
                    Console.WriteLine("New blance: " + Balance);
                    Console.WriteLine();
                    Options();
                }

                else
                {
                    Console.WriteLine("Incorrect command");
                    Console.WriteLine();
                    Options();
                }
            }
            Console.WriteLine("Transaction complete");
        }
    }
}
