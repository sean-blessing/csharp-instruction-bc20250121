namespace LeetCodeTwoSumDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the TwoSum LeetCode Challenge!");

            int[] nums = [2, 7, 11, 15];
            // test case 1
            int[] indices = TwoSum(nums, 9);
            DisplayResults(indices, "Test Case 1");

            nums = [3, 2, 4];
            // test case 2
            indices = TwoSum(nums, 6);
            DisplayResults(indices, "Test Case 2");

            nums = [1, 3, 7, 12, 15];
            // test case 3
            indices = TwoSum(nums, 19);
            DisplayResults(indices, "Test Case 3");
            Console.WriteLine("Bye");
        }

        static void DisplayResults(int[] indices, string msg) {
            PrintLine(msg);
            foreach (int i in indices) {
                Print($"index: {i}, ");
            }
            PrintLine("");
        }

        static int[] TwoSum(int[] nums, int target) {
            int[] indices = new int[2];
            // nums - array of ints, one pair of numbers, summed, equals target
            // return indices of those two numbers
            // my first #
            bool found = false;
            for (int i = 0; i < nums.Length; i++) {
                if (found) {
                    break;
                }
                // my second #
                for (int j = 0; j < nums.Length; j++) {
                    if (i != j) {
                        //Print($"{nums[i]} + {nums[j]}, ");
                        int sum = nums[i] + nums[j];
                        if (sum == target) {
                            //Print("Target!!!");
                            indices = [i, j];
                            found = true; 
                            break;
                        }
                    }
                }
                //PrintLine("");
            }

            return indices;
        }

        static void Print(string msg) {
            Console.Write(msg);
        }

        static void PrintLine(string msg) {
            Console.WriteLine(msg);
        }
    }
}
