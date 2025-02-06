namespace Chap07ExTipCalculator {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Tip Calculator!");

            string choice = "y";
            while (choice == "y") {
                Console.Write("Cost of meal: ");
                // skipping validation - assume user enters valid cost
                decimal costOfMeal = Decimal.Parse(Console.ReadLine());
                // biz logic:
                // - calculate and display tipAmt: decimal and totalAmt: decimal for .15, .20 and .25
                // for decimal d = .15m; d <= .25m; d+=.05
                for (decimal d = .15m; d <= .25m; d+=.05m) {
                    decimal tipAmt = costOfMeal * d;
                    decimal totalAmt = costOfMeal + tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("Tip Amount: "+tipAmt.ToString("c"));
                    Console.WriteLine("Total Amount: "+totalAmt.ToString("c"));
                    Console.WriteLine();
                }

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }



            Console.WriteLine("bye");
        }
    }
}
