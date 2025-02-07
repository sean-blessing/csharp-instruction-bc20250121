using System.Text;

namespace Chap09Demos {
    internal class Program {
        static void Main(string[] args) {
            PrintLine("Welcome to Strings and Dates!");

            // p. 275
            // what's the current date and time?
            DateTime currentDateTime = DateTime.Now;
            // what's the current date?
            DateTime today = DateTime.Today;

            // string contatentation
            PrintLine("Current date = "+currentDateTime+".");
            // string interpolation
            PrintLine($"today = {today}.");

            // p. 277
            PrintLine($"longDate: {currentDateTime.ToLongDateString()}");
            PrintLine($"longTime: {currentDateTime.ToLongTimeString()}");
            PrintLine($"shortDate: {currentDateTime.ToShortDateString()}");
            PrintLine($"shortTime: {currentDateTime.ToShortTimeString()}");

            // p. 279 get information about a date:
            PrintLine($"Month: {currentDateTime.Month}");
            PrintLine($"Day: {currentDateTime.Day}");
            PrintLine($"DayOfWeek: {currentDateTime.DayOfWeek}");
            PrintLine($"DayOfYear: {currentDateTime.DayOfYear}");
            PrintLine($"Year: {currentDateTime.Year}");
            PrintLine($"Days in month - 2025, 2: {DateTime.DaysInMonth(2025, 2)}");
            PrintLine($"Leapyear - 2028: {DateTime.IsLeapYear(2028)}");

            // p. 281 manipulate dates and times
            // due date in 2 months:
            DateTime dueDate = currentDateTime.AddMonths(2);
            PrintLine($"dueDate: {dueDate}");

            // Halloween 2025
            DateTime halloween = new DateTime(2025, 10, 31);
            PrintLine($"halloween: {halloween}");

            PrintLine($"halloween > today? {halloween > currentDateTime}");
            TimeSpan timeTillHalloween = halloween.Subtract(currentDateTime);
            PrintLine($"Days until Halloween: {timeTillHalloween.Days}");

            // Strings - p. 285
            // loop thru characters in a string
            string sentence = "Woohoo! So glad today is Friday!";
            foreach (char c in sentence) {
                Print(c + " ");
            }
            PrintLine("");

            // hangman - creating an underscore version of a word
            // word is "superman", the hiddenVersion would be "_ _ _ _ _ _ _ _"
            string word = "superman";
            string hiddenVersion = "";
            foreach (char c in word) {
                hiddenVersion += "_ ";
            }
            hiddenVersion = hiddenVersion.Trim();
            PrintLine($"The word is {word}.");
            PrintLine($"The hiddenVersion is {hiddenVersion}.");

            //p. 293 
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", how ");
            sb.Append("are you?");
            PrintLine(sb.ToString());

            PrintLine("bye");
        }

        static void Print(string message) {
            Console.Write(message);
        }

        static void PrintLine(string message) {
            Console.WriteLine(message);
        }


    }
}
