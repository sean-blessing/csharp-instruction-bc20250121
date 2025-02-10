namespace LeetCode01TwoSum {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Two Sum Testing!");

            Console.WriteLine("---- Example 1 ----");
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums, target);
            DisplayResults(indices);
            Console.WriteLine();

            Console.WriteLine("---- Example 2 ----");
            nums = new int[] { 3, 2, 4 };
            target = 6;
            indices = TwoSum(nums, target);
            DisplayResults(indices);
            Console.WriteLine();

            Console.WriteLine("---- Example 3 ----");
            nums = new int[] { 3,3 };
            target = 6;
            indices = TwoSum(nums, target);
            DisplayResults(indices);
            Console.WriteLine();

            Console.WriteLine("bye");
        }

        static void DisplayResults(int[] indices) {
            Console.WriteLine("indices: ");
            foreach (int i in indices) {
                Console.WriteLine($"indices: {i}");
            }
        }

        static int[] TwoSum(int[] nums, int target) {
            int[] indices = [];
            for (int i = 0; i < nums.Length; i++) {
                if (indices.Length > 0) {
                    break;
                }
                for (int j = 0; j < nums.Length; j++) {
                    if (j != i) {
                        if (nums[i] + nums[j] == target) {
                            indices = [i, j];
                            break;
                        }
                    }
                }
            }
            return indices;
        }
    }
}
