namespace LeetCode01TwoSum {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Two Sum Testing!");

            // example 1
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] indices = TwoSum(nums, target);

            Console.WriteLine("indices: ");
            foreach (int i in indices) {
                Console.WriteLine($"indices: {indices[i]}");
            }


            Console.WriteLine("bye");
        }

        static int[] TwoSum(int[] nums, int target) {
            int[] indices = new int[2];
            // write the method!

            return indices;
        }
    }
}
