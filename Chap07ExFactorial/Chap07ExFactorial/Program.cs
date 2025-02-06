namespace Chap07ExFactorial {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial App!");

            string choice = "y";
            while (choice == "y") {
                // get input theNumber: long
                //long theNumber = GetLong("Enter an integer that's greater than 0 and less than 1000: ", 1, 1000);
                //// compute the factorial w/ for loop - factorial: long = 1
                //// for i = 1, i <= theNumber, i++ => factorial = factorial * i
                //long theFactorial = 1;
                //for (int i = 1; i <= theNumber; i++) {
                //    //theFactorial = theFactorial * i;
                //    theFactorial *= i;
                //}
                //Console.WriteLine("The factorial of " + theNumber + " is " + theFactorial + ".");

                long theFactorial = 1;
                for (int i = 1; i <= 30; i++) {
                    theFactorial *= i;
                    Console.WriteLine("i: " + i + ", factorial: " + theFactorial);
                }
                Console.Write("Continue? (y/n) ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Bye");
        }

        private static long GetLong(string prompt, long min, long max) {
            long result = 0;
            bool isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result)) {
                    Console.WriteLine("Error - invalid whole number. Try again.");
                    continue;
                }
                if (result < min || result > max) {
                    Console.WriteLine("Error - input must be within range (" + min + "-" + max + "). Try again.");
                }
                else {
                    isValid = true;
                }
            }

            return result;
        
        }
    }
}
