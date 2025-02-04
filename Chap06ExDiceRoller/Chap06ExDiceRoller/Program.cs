namespace Chap06ExDiceRoller {
    internal class Program {
        static void Main(string[] args) {
            Print("Dice Roller!");
            Print("");

            string choice = PromptChoice("Roll the dice ? ");
            Print("");
            Random rand = new Random();
            while (choice == "y") {
                int die1 = RollDie(rand);
                int die2 = RollDie(rand);
                int total = die1 + die2;
                DisplayResults(die1, die2, total);
                Print("");
                choice = PromptChoice("Roll again? (y/n): ");
                Print("");
            }
            Print("Bye");
        }

        private static string PromptChoice(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        private static void DisplayResults(int die1, int die2, int total) {
            Print("Die 1: " + die1);
            Print("Die 2: " + die2);
            Print("Total: " + total);
            if (total == 2) {
                Print("Snake eyes!");
            }
            else if (total == 12) {
                Print("Box cars!");
            }
        }

        private static int RollDie(Random rand) {
            return rand.Next(1, 7);
        }

        private static void Print(string message) {
            Console.WriteLine(message);
        }
    }
}
