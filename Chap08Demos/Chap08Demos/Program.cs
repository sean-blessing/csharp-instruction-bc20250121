namespace Chap08Demos {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 8 - arrays");

            // p. 231
            // array of strings - names
            string[] names = new string[9];
            names[0] = "Jim";
            names[1] = "Andy";
            names[2] = "Nick";
            names[3] = "Christian";
            names[4] = "Adrian";
            names[5] = "Sean";
            names[6] = "Celina";
            names[7] = "Heath";
            names[8] = "Joe";

            Console.WriteLine("names = " + names);
            Console.WriteLine("position 0: " + names[0]);

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine("i: " + i + ", name: " + names[i]);
            }

            //names[9] = "new person";

            decimal[] prices = { 1.99m, 2.25m, 4.5m };
            for (int i = 0; i < prices.Length; i++) {
                Console.WriteLine("i:" + i + ", price: " + prices[i]);
            }

            // infer the type of an array:
            var grades = new[] { 95.0, 89.0, 91.0, 98.0 };
            double sum = 0;
            for (int i = 0;i < grades.Length; i++) {
                sum += grades[i];
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: " + sum / grades.Length);
            //var stuff = new[] { "A", 5, 7.7 };

            string fullName = "Bob Nesta Marley";
            for (int i = 0; i <  fullName.Length; i++) {
                Console.Write(fullName[i] + " ");
            }
            Console.WriteLine();

            // for each loop
            // loop through names and print on one line
            foreach (string name in names) {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            // p. 239
            // 3 x 4 grid
            // 1  2  3  4
            // 5  6  7  8
            // 9 10 11 12

            int[,] grid = new int[3,4];
            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[0, 2] = 3;
            grid[0, 3] = 4;
            grid[1, 0] = 5;
            grid[1, 1] = 6;
            grid[1, 2] = 7;
            grid[1, 3] = 8;
            grid[2, 0] = 9;
            grid[2, 1] = 10;
            grid[2, 2] = 11;
            grid[2, 3] = 12;

            // print grid
            // i loop - rows
            string gridString = "";
            for (int i = 0; i < grid.GetLength(0); i++) {
                // j loop - columns
                for (int j = 0; j < grid.GetLength(1); j++) {
                    gridString += grid[i, j] + "\t";
                }
                gridString += "\n";
            }
            Console.WriteLine(gridString);

            // Array class
            Array.Sort(names);
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            // for project 8-2 Sales Report
            double[,] sales = { {1540.0, 2010.0, 2450.0, 1845.0}, 
                                {1130.0, 1168.0, 1847.0, 1491.0}, 
                                {1580.0, 2305.0, 2710.0, 1284.0}, 
                                {1105.0, 4102.0, 2391.0, 1576.0}};




            Console.WriteLine("Bye");
        }
    }
}
