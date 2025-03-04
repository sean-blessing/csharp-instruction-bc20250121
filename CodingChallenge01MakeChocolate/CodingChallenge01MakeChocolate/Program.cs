namespace CodingChallenge01MakeChocolate {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's make some chocolate!");

            // test case: makeChocolate(4, 1, 9) → 4
            Console.WriteLine($"makeChocolate(4, 1, 9): {makeChocolate(4, 1, 9)}");

            // makeChocolate(4, 1, 10) → -1
            Console.WriteLine($"makeChocolate(4, 1, 10): {makeChocolate(4, 1, 10)}");

            // makeChocolate(4, 1, 7) → 2
            Console.WriteLine($"makeChocolate(4, 1, 7): {makeChocolate(4, 1, 7)}");

            Console.WriteLine("Bye");
        }

        public static int makeChocolate(int small, int big, int goal) {
            int result = 0;
            // goal - (big * 5) = smallKilos
            // if (smallKilos <= small) => return smallKilos else return -1
            int smallKilos = goal - (big * 5);
            result = (smallKilos <= small) ? smallKilos : -1;

            return result;
        }
    }
}
