namespace Chap08ListsGetByIndex {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to a supplemental demo on Lists!");
            List<int> list = new List<int> { 2, 5, 20, 3, 7, 9 };
            foreach (int i in list) {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine($"i: {i}, {list[i]}");
            }

            Console.WriteLine($"element at index 2: {list[2] }");

            Console.WriteLine("bye");
        }
    }
}
