using ConsoleUtil;

namespace Chap12ExGuessingGame {
    public class Game {
        public int Count { get; set; }
        public int Diff {  get; set; }

        public void DisplayGuessMessage() {
            if (Diff == 0) {
                DisplayWinnerMessage();
            }
            else if (Diff < -10) {
                MyConsole.PrintLine("Way too low! Guess again.");
            }
            else if (Diff < 0) {
                MyConsole.PrintLine("Too low! Guess again.");
            }
            else if (Diff > 10) {
                MyConsole.PrintLine("Way too high! Guess again.");
            }
            else if (Diff > 0) {
                MyConsole.PrintLine("Too high! Guess again.");
            }
        }

        private void DisplayWinnerMessage() {
            MyConsole.PrintLine("You got it in " + Count + " tries.");
            if (Count <= 3) {
                MyConsole.PrintLine("Great work! You are a mathematical wizard.");
            }
            else if (Count <= 7) {
                MyConsole.PrintLine("Not too bad! You've got some potential.");
            }
            else {
                MyConsole.PrintLine("What took you so long? Maybe you should take some lessons.");
            }
        }

    }
}
