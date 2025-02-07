namespace Chap08SalesReport {
    internal class Program {
        static void Main(string[] args) {
            PrintLine("Welcome to the Sales Report Application!\n");
            decimal[,] sales = {
                {1540.0m, 2010.0m, 2450.0m, 1845.0m}, // Region 1 
                {1130.0m, 1168.0m, 1847.0m, 1491.0m}, // Region 2 
                {1580.0m, 2305.0m, 2710.0m, 1284.0m}, // Region 3 
                {1105.0m, 4102.0m, 2391.0m, 1576.0m}  // Region 4 
            };
            decimal sum = 0.0m;

            // 1) Dump data to console by region (rows), quarter (columns)
            PrintLine("Region\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i=0; i < sales.GetLength(0); i++) {
                Print((i + 1) + "\t");
                for (int j = 0; j < sales.GetLength(1); j++) {
                    Print(sales[i,j].ToString("c") + "\t");
                }
                PrintLine("");
            }
            PrintLine("");

            // 2) Sum Sales by region (regions 1, 2, 3, and 4)
            PrintLine("Sales by region:");
            for (int i = 0; i < sales.GetLength(0); i++) {
                Print("Region "+(i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine("");

            // 3) Sum Sales by quarter (q1, q2, q3, q4)
            PrintLine("Sales by quarter:");
            for (int i = 0; i < sales.GetLength(0); i++) {
                Print("Q" + (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[j, i];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine("");

            // 4) Total sales (sum of all data)
            sum = 0.0m;
            Print("Total Sales: ");
            for (int i = 0; i < sales.GetLength(0); i++) {
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
            }
            PrintLine(sum.ToString("c"));
            PrintLine("\nBye");
        }

        static void PrintLine(string message) {
            Console.WriteLine(message);
        }

        static void Print(string message) {
            Console.Write(message);
        }
    }
}
