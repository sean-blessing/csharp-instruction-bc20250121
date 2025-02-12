namespace ConsoleUtil {
    public class MyConsole {
        public static int PromptInt(string prompt) {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result)) {
                    isValid = true;
                }
                else {
                    PrintLine("Error - invalid int.");
                }
            }

            return result;
        }

        public static int PromptInt(string message, int min, int max) {
            int result = 0;
            bool isValid = false;
            // validation: 1) whole #, 2) range
            while (!isValid) {
                result = PromptInt(message);
                if (result >= min && result <= max) {
                    isValid = true;
                }
                else {
                    PrintLine("Error - int must be within range " + min + " - " + max);
                }
            }
            return result;
        }

        public static double PromptDouble(string prompt) {
            double result = 0;
            return result;
        }

        public static string PromptString(string prompt) {
            Print(prompt);
            return Console.ReadLine();
        }

        public static string PromptReqString(string prompt, string str1, string str2) {
            string result = "";
            bool isValid = false;
            while (!isValid) {
                result = PromptString(prompt);
                if (result.Trim() != "") {
                    if (result == str1 || result == str2) {
                        isValid = true;
                    }
                    else {
                        PrintLine("Error - string must be either " + str1 + " or " + str2);
                    }
                }
                else {
                    PrintLine("Error - entry is required.");
                }
            }
            return result;
        }

        public static void Print(string msg) {
            Console.Write(msg);
        }

        public static void PrintLine(string msg) {
            Console.WriteLine(msg);
        }

    }
}
