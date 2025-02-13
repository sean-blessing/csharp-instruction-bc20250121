namespace Chap15ExAnimalCounter.Model {
    internal interface Countable {
        void IncrementCount();
        void ResetCount();
        string GetCountString();
    }
}
