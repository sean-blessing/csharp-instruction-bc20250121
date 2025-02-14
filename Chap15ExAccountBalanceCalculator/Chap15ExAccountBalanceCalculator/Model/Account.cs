namespace Chap15ExAccountBalanceCalculator.Model {
    internal class Account : Depositable, Withdrawable, Balanceable {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount) {
            Balance += amount;
        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}
