using ConsoleUtil;

namespace ConsoleChangeTester {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Hello, World!");
            // MyConsole.PromptDouble()?? - need to add to MyConsole
            double dbl = MyConsole.PromptDouble("test");
        }
    }
}
