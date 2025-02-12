namespace Chap06GuessingGame {
    internal class Program {
        // constants
        const int MIN_VAL = 1; 
        const int MAX_VAL = 100;
        static void Main(string[] args) {
            Print("Welcome to the Guessing Game!");
            Print("+++++++++++++++++++++++++++++");
            Print("");

            string choice = "y";
            Random rand = new Random();
            while (choice == "y") {
                // play game
                int theNumber = rand.Next(MIN_VAL,MAX_VAL+1);
                int count = 0;
                int guess = 0;
                Print("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
                //Print("** DEBUG: theNumber = " + theNumber);
                // play game until guess == theNumber
                while (guess != theNumber) {
                    guess = GetNumber("Enter number: ");
                    count++;
                    int diff = guess - theNumber;
                    if (diff == 0) {
                        DisplayWinnerMessage(count);
                    }
                    else if (diff < -10) {
                        Print("Way too low! Guess again.");
                    }
                    else if (diff < 0) {
                        Print("Too low! Guess again.");
                    }
                    else if (diff > 10) {
                        Print("Way too high! Guess again.");
                    }
                    else if (diff > 0)
                    {
                        Print("Too high! Guess again.");
                    }
                }
                // prompt choice
                Print("");
                choice = GetRequiredString("Try again? (y/n) ", "y", "n");
                Print("");
            }

            Print("Bye - come back again soon!");
        }

        static void DisplayWinnerMessage(int count) {
            Print("You got it in " + count + " tries.");
            if (count <= 3) {
                Print("Great work! You are a mathematical wizard.");
            }
            else if (count <= 7) {
                Print("Not too bad! You've got some potential.");
            }
            else {
                Print("What took you so long? Maybe you should take some lessons.");
            }
        }

        static void Print(string msg) {
            Console.WriteLine(msg);
        }

        static string GetRequiredString(string prompt, string val1, string val2) {
            string str = "";
            // while true - on purpose!!!
            while (true) {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "") {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2) {
                    Print("Error - entry must be either " + val1 + " or " + val2);
                }
                else {
                    break;
                }
            }
            return str;
        }

        static int GetNumber(string prompt) {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                // was user entry a whole number?
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                //catch {
                //    Print("Error - entry must be a whole number.");
                //    continue;
                //}
                catch (Exception e) {
                    Print("Error - entry must be a whole number.");
                    //Console.Error.WriteLine("e.Message: " + e.Message);
                    //Console.Error.WriteLine("e.ToString(): " + e.ToString());
                    continue;
                }
                if (nbr >= MIN_VAL && nbr <= MAX_VAL) {
                    success = true;
                }
                else {
                    Print("Error - entry must be between " + MIN_VAL + " and " + 100 + ".");
                }
            }

            return nbr;
        }
    }
}
