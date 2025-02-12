namespace Chap14Demos {
    public abstract class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product() { }
        public Product(string Code, string Description, decimal Price) {
            this.Code = Code;
            this.Description = Description;
            this.Price = Price;
        }

        public virtual string GetDisplayText(string sep) {
            return $"{Code}{sep}{Price:c}{sep}{Description}";
        }

    }
}
