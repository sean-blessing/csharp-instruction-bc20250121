using System.Xml.Serialization;

namespace Chap08BattingStatsPrep {
    internal class Program {
        static void Main(string[] args) {
            Print("Welcome to the Batting Average Calculator!\n");

            string choice = "y";
            while (choice == "y") {
                int nbr = PromptInt("Enter number of times at bat: ", 1, 30);
                double[] atBats = new double[nbr];
                for (int i = 0; i < atBats.Length; i++) {
                    atBats[i] = (double)PromptInt("Result for at-bat "+(i+1)+": ", 0, 4);
                }
                Print("");
                double hits = 0.0;
                double basesEarned = 0.0;
                foreach (int i in atBats) {
                    if (i > 0) {
                        hits++;
                        basesEarned += i;
                    }
                }
                double battingAvg = hits / nbr;
                double sluggingPct = basesEarned / nbr;

                Print("\nBatting Average: " + battingAvg.ToString("f3"));
                Print("Slugging Percent:  " +  sluggingPct.ToString("f3"));
                Print("");

                choice = PromptString("Another Player? (y/n) ");
                Print("");
            }
            Print("Bye");
        }

        private static void Print(string text) {
            Console.WriteLine(text);
        }

        private static string PromptString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static int PromptInt(string prompt, int min, int max) {
            bool isValid = false;
            int result = 0;

            while (!isValid) {
                if (!Int32.TryParse(PromptString(prompt), out result)) {
                    Console.WriteLine("Error - invalid int. Try again.");
                }
                else {
                    if (result < min || result > max) {
                        Console.WriteLine("Error - Out of valid range(" + min + "-" + max + "). Try again.");
                    }
                    else {
                        isValid = true;
                    }
                }
            }

            return result;
        }
    }
}
