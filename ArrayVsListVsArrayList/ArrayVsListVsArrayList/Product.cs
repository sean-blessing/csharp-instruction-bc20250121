using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsListVsArrayList {
    internal class Product {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int productID, string code, string description, decimal price) {
            this.ProductID = productID;
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString() {
            return $"Product: {ProductID}|{Code}|{Description}|{Price:c}";
        }
    }
}
