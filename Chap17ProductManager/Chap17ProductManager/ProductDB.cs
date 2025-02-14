using System.Runtime.CompilerServices;

namespace Chap17ProductManager {
    internal class ProductDB {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Products.txt";
        private const string Sep = "|";

        public static void SaveProducts(List<Product> products) {
            using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Product product in products) {
                writer.Write(product.Code + Sep);
                writer.Write(product.Description + Sep);
                writer.WriteLine(product.Price);
            }

            // writer.Close(); => eliminated by 'using' statement
        }

        public static List<Product> GetProducts() {
            using StreamReader reader = new (new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Product> products = new List<Product>();
            while (reader.Peek() != -1) {
                string row = reader.ReadLine();
                string[] cols = row.Split(Sep);

                if (cols.Length == 3) {
                    string code = cols[0];
                    string description = cols[1];
                    decimal price = Decimal.Parse(cols[2]);
                    Product p = new Product(code, description, price);
                    products.Add(p);
                }
            }
            return products;
        }

    }
}
