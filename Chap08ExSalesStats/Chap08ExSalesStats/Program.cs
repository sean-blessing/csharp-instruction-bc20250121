namespace Chap08ExSalesStats {
    internal class Program {
        static void Main(string[] args) {
            Print("Welcome to the Sales Report Application!\n");
            // for project 8-2 Sales Report
            double[,] sales = { {1540.0, 2010.0, 2450.0, 1845.0},
                                {1130.0, 1168.0, 1847.0, 1491.0},
                                {1580.0, 2305.0, 2710.0, 1284.0},
                                {1105.0, 4102.0, 2391.0, 1576.0}};

            Print("Region\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++) {
                string row = (i + 1) + "\t";
                for (int j = 0; j < sales.GetLength(1); j++) {
                    row += sales[i, j].ToString("c") + "\t";
                }
                Print(row);
            }
            Print("\nSales by Region:");
            for (int i = 0; i < sales.GetLength(0); i++) {
                string row = "Region " + (i + 1) + ": ";
                double sum = 0;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
                row += sum.ToString("c");
                Print(row);
            }
            Print("\nSales by Quarter:");
            for (int j = 0; j < sales.GetLength(1); j++) {
                string row = "Q" + (j + 1) + ": ";
                double sum = 0;
                for (int i = 0; i < sales.GetLength(0); i++) {
                    sum += sales[i, j];
                }
                row += sum.ToString("c");
                Print(row);
            }
            double total = 0.0;
            for (int i = 0; i < sales.GetLength(1); i++) {
                for (int j = 0; j < sales.GetLength(0); j++) {
                    total+= sales[i, j];
                }
            }
            Print("\nTotal Sales:"+total.ToString("c"));

            Print("Bye");
        }


        private static void Print(string s) {
            Console.WriteLine(s);
        }
    }
}
