namespace Chap15ExAnimalCounter.Model {
    internal abstract class Animal : Countable {
        public int Count { get; set; }

        public Animal() { 
            this.Count = 0;
        }

        public abstract string GetCountString();

        public void IncrementCount() {
            Count++;
        }

        public void ResetCount() {
            Count = 0;
        }
    }
}
