using System.ComponentModel;

namespace Chap5ExChangeCalc {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the change calculator!");
            
            string choice = "y";
            while (choice == "y") {
                // get input - cents: int
                Console.Write("\nEnter number of cents (0-99): ");
                int cents = Int32.Parse(Console.ReadLine());
                // biz logic:
                // - quarters: int = cents / 25
                int quarters = cents / 25;
                // - cents = cents % 25
                cents %= 25;
                // - dimes: int = cents / 10
                int dimes = cents / 10;
                // - cents = cents % 10
                cents %= 10;
                // - nickels: int = cents / 5
                int nickels = cents / 5;
                // - pennies: int = cents % 5
                int pennies = cents % 5;
                Console.WriteLine();
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes:    " + dimes);
                Console.WriteLine("Nickels:  " + nickels);
                Console.WriteLine("Pennies:  " + pennies);
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }



            Console.WriteLine("Bye");
        }
    }
}
