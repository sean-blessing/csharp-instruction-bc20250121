using Chap15ExAnimalCounter.Model;
using ConsoleUtil;

namespace Chap15ExAnimalCounter.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Animal Counter!\n");
            Alligator a = new Alligator();
            MyConsole.PrintLine("Counting alligators...\n");
            count(a, 3);

            MyConsole.PrintLine("\nCounting sheep...\n");
            Sheep s = new Sheep();
            s.Name = "Blackie";
            count(s, 2);


            MyConsole.PrintLine("\nBye");
        }

        public static void count(Countable c, int maxCount) {
            for (int i = 0; i < maxCount; i++) {
                c.IncrementCount();
                MyConsole.PrintLine(c.GetCountString());
            }
        }
    }
}
