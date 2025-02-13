namespace Chap14ExPersonManager.Model {
    internal class Customer : Person {
        public string CustomerNumber { get; set; }

        public Customer(string firstName, string lastName, string customerNumber) :
            base(firstName, lastName) {
            this.CustomerNumber = customerNumber;    
        }

        public override string ToString() {
            return $"{base.ToString()}Customer Number: {CustomerNumber}";
        }
    }
}
