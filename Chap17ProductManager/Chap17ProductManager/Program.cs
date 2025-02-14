using ConsoleUtil;

namespace Chap17ProductManager {
    internal class Program {
        static List<Product> products = new List<Product>();
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the product manager!\n");

            // Program that provides CRUD features for products
            // Products will be stored in a text file names products.txt

            // load products from file
            products = ProductDB.GetProducts();

            int command = 9;
            while (command != 0) {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command) {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }

            MyConsole.PrintLine("bye");
        }

        private static void AddProduct() {
            MyConsole.PrintLine("\nAdd Product:");
            MyConsole.PrintLine("=================================");
            string code = MyConsole.PromptString("Code: ");
            string desc = MyConsole.PromptString("Description: ");
            decimal price = MyConsole.PromptDecimal("Price: ");
            Product p = new Product(code, desc, price);
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintLine("Product added.");
        }

        private static void ListProducts() {
            MyConsole.PrintLine("\nList Products:");
            MyConsole.PrintLine("=================================");
            // check to see if list is not empty
            foreach (Product p in products) {
                MyConsole.PrintLine(p.ToString());
            }
        }

        static void DisplayMenu() {
            MyConsole.PrintLine("\nCOMMAND MENU:");
            MyConsole.PrintLine("1) List Products");
            MyConsole.PrintLine("2) Add Product");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
