using ConsoleUtil;

namespace Chap12ExGuessingGame {
    internal class Program {
        // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Guessing Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++");
            MyConsole.PrintLine("");

            string choice = "y";
            Random rand = new Random();
            while (choice == "y") {
                // play game
                int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;
                MyConsole.PrintLine("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
                //Print("** DEBUG: theNumber = " + theNumber);
                // play game until guess == theNumber
                while (guess != theNumber) {
                    guess = MyConsole.PromptInt("Enter number: ");
                    count++;
                    int diff = guess - theNumber;
                    Game game = new Game();
                    game.Diff = diff;
                    game.Count = count;
                    game.DisplayGuessMessage();
                }
                // prompt choice
                MyConsole.PrintLine("");
                choice = MyConsole.PromptReqString("Try again? (y/n) ", "y", "n");
                MyConsole.PrintLine("");
            }
            MyConsole.PrintLine("Bye - come back again soon!");
        }
    }
}
