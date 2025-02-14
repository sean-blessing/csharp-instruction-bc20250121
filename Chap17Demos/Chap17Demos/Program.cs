using ConsoleUtil;

namespace Chap17Demos {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the file demo!\n");

            string dir = @"C:\C#\Files\";
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine("dir created!");
            }
            else {
                MyConsole.PrintLine("dir already exists.");
            }
            string path = dir + "names.txt";
            if (!File.Exists(path)) {
                File.Create(path);
                MyConsole.PrintLine("file created!");
            }
            else {
                MyConsole.PrintLine("file already exists.");
            }

            // write some names to our file...
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Adrian");
            //writer.WriteLine("Jim");
            //writer.WriteLine("Celina");
            //writer.WriteLine("Nick");
            //writer.WriteLine("Drew");
            //writer.Close();
            //MyConsole.PrintLine("names writing done.");

            MyConsole.PrintLine("==== reading names.txt ====");
            StreamReader reader = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            List<string> lines = new List<string>();
            while (reader.Peek() != -1) {
                string row = reader.ReadLine() ?? "";
                lines.Add(row);
            }
            reader.Close();

            foreach (string line in lines) {
                MyConsole.PrintLine($"line = {line}");
            }

            MyConsole.PrintLine("Bye");
        }
    }
}
