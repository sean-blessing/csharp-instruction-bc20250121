namespace Ch08DemoLists {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Collections!");

            // just for reference
            Random rand = new Random();  // Creates a new instance of the Random class
            int dieRoll = rand.Next(1, 7);

            // p. 257
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int i in numbers) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<string> names = new List<string>();
            names.Add("Jim");
            names.Add("Andy");
            names.Add("Nick");
            names.Add("Christian");
            names.Add("Adrian");
            names.Add("Sean");
            names.Add("Celina");
            names.Add("Joe");
            names.Add("Heath");

            names.Insert(4, "Test");

            foreach (string n in names) {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine(names);

            Console.WriteLine("Adrian? "+names.Contains("Adrian"));

            names.Remove("Test");
            foreach (string n in names) {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // what's the index position for "Celina"?
            Console.WriteLine("Celina in position: " + names.BinarySearch("Celina"));
            Console.WriteLine("Celina in position: " + names.IndexOf("Celina"));

            Console.WriteLine("bye");
        }
    }
}
