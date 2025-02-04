namespace Chap05ExTravelTime {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Travel Time Calculator app!!");

            string choice = "y";

            while (choice == "y") {
                //get input: miles, mph
                Console.WriteLine("Enter miles: ");
                double miles = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter mph: ");
                double mph = Double.Parse(Console.ReadLine());

                // biz logic: hours and minutes (whole numbers)
                // totaltime: double = miles/mph
                // hours: int = (int)totaltime
                // minutes: int = (int)((miles % mph)*60)
                double totalTime = miles / mph;
                int hours = (int)totalTime;
                double remainder = totalTime - hours;
                int minutes = (int)((remainder) * 60);

                // display output
                Console.WriteLine("Hours:    " + hours);
                Console.WriteLine("Minutes:  " + minutes);


                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("bye");
        }
    }
}
