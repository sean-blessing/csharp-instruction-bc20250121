namespace Chap16ExDiceRoller {
    public class Die {
        public int Value { get; set; }

        public Die() { 
            this.Value = 0;
        }

        public void Roll() {
            Random r = new Random();
            this.Value = r.Next(1, 7);
        }

    }
}
