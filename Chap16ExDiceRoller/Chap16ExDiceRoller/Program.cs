using ConsoleUtil;

namespace Chap16ExDiceRoller {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Dice Roller Game!\n");

            string choice = MyConsole.PromptString("Roll the dice? (y/n): ").ToLower();
            while (choice == "y") {
                Dice dice = new Dice();
                dice.Roll();
                MyConsole.PrintLine(dice.GetRollResults());
                choice = MyConsole.PromptString("Roll again? (y/n): ");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
