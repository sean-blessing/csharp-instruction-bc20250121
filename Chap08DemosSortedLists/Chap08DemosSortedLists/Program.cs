using ConsoleUtil;
using System.Linq.Expressions;

namespace Chap08DemosSortedLists {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the SortedLists Demo!\n");

            // p. 262
            // create a SortedList of usStates
            SortedList<string, string> usStates = new SortedList<string, string>();
            usStates.Add("OH", "Ohio");
            usStates["IN"] = "Indiana";
            usStates.Add("CO", "Colorado");
            usStates.Add("CA", "California");
            usStates.Add("MI", "Michigan");

            // get all entries
            foreach (KeyValuePair<string, string> state in usStates) {
                MyConsole.PrintLine($"{state.Key}: {state.Value}");
            }

            // get all keys
            foreach (string s in usStates.Keys) {
                MyConsole.Print(s + "|");
            }
            MyConsole.PrintLine("");

            // get all values
            foreach (string s in usStates.Values) {
                MyConsole.Print(s + "|");
            }

            MyConsole.PrintLine("");

            // p. 263 collection initializer
            //usStates = new SortedList<string, string>{ {"OH", "Ohio" }, {"IN", "Indiana" },
            //    {"CO", "Colorado" }, {"MI", "Michigan" }, {"AL", "Alabama"}, {"HI", "Hawaii"} };

            // using chat gpt
            usStates = new SortedList<string, string> {
                { "AL", "Alabama" }, { "AK", "Alaska" }, { "AZ", "Arizona" },
                { "AR", "Arkansas" }, { "CA", "California" }, { "CO", "Colorado" },
                { "CT", "Connecticut" }, { "DE", "Delaware" }, { "FL", "Florida" },
                { "GA", "Georgia" }, { "HI", "Hawaii" }, { "ID", "Idaho" },
                { "IL", "Illinois" }, { "IN", "Indiana" }, { "IA", "Iowa" },
                { "KS", "Kansas" }, { "KY", "Kentucky" }, { "LA", "Louisiana" },
                { "ME", "Maine" }, { "MD", "Maryland" }, { "MA", "Massachusetts" },
                { "MI", "Michigan" }, { "MN", "Minnesota" }, { "MS", "Mississippi" },
                { "MO", "Missouri" }, { "MT", "Montana" }, { "NE", "Nebraska" },
                { "NV", "Nevada" }, { "NH", "NewHampshire" }, { "NJ", "NewJersey" },
                { "NM", "NewMexico" }, { "NY", "NewYork" }, { "NC", "NorthCarolina" },
                { "ND", "NorthDakota" }, { "OH", "Ohio" }, { "OK", "Oklahoma" },
                { "OR", "Oregon" }, { "PA", "Pennsylvania" }, { "RI", "RhodeIsland" },
                { "SC", "SouthCarolina" }, { "SD", "SouthDakota" }, { "TN", "Tennessee" },
                { "TX", "Texas" }, { "UT", "Utah" }, { "VT", "Vermont" },
                { "VA", "Virginia" }, { "WA", "Washington" }, { "WV", "WestVirginia" },
                { "WI", "Wisconsin" }, { "WY", "Wyoming" }
            };

            MyConsole.PrintLine("=== all 50 states ===");
            string sa = "";
            while (sa != "EX") {
                sa = MyConsole.PromptString("State Abbrev: ").ToUpper();
                if (sa == "EX") break;
                string sn = "";
                try {
                    sn = usStates[sa];
                }
                catch (Exception) {
                    MyConsole.PrintLine($"Error - no state for '{sa}'.");
                    continue;
                }
                MyConsole.PrintLine(sn);
            }

            MyConsole.PrintLine("\nBye");
        }
    }
}
