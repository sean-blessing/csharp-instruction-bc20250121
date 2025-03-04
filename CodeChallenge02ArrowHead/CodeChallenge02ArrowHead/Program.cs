namespace CodeChallenge02ArrowHead {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Arrowhead Challenge\n");

            string choice = "y";
            while (choice == "y") {
                Console.Write("Enter length of arrowhead: ");
                int length = Int32.Parse(Console.ReadLine());
                if (length % 2 == 0) {
                    length++;
                }
                int midpoint = (int)Math.Ceiling((double)length / 2);
                Console.WriteLine($"length: {length}, midpoint: {midpoint}");

                string output = "";
                for (int i = 1; i <= midpoint; i++) {
                    output += ">";
                    Console.WriteLine(output);
                }
                for (int i = 1; i < midpoint; i++) {
                    output = output.Substring(0, output.Length - 1);
                    Console.WriteLine(output);
                }


                Console.Write("Again? (y/n) ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }
    }
}
