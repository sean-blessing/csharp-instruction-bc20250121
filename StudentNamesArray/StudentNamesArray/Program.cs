using ConsoleUtil;

namespace StudentNamesArray {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to Student Array App!\n");

            // prompt user for # of students
            int nbrStudents = MyConsole.PromptInt("Number of students: ");
            string[] studentArray = new string[nbrStudents];

            // for loop - loop through studentArray
            for (int i = 0; i < nbrStudents; i++) {
                // - for each position in the array:
                //   - prompt name
                string name = MyConsole.PromptString($"Student Name[{i}]: ");
                //   - add name to studentArray
                studentArray[i] = name;
            }

            // print the array - on one line - one way
            //string names = "";
            //foreach (string n in studentArray) {
            //    names += n + "|";
            //}
            //Console.WriteLine(names);

            // another way
            //foreach (string n in studentArray) {
            //    MyConsole.Print(n + "|");
            //}
            //MyConsole.PrintLine();

            // third way - lambdas
            Array.Sort(studentArray);
            Array.ForEach(studentArray, s => Console.Write(s + "|"));
            //studentArray.ForEach(studentArray, s => Console.Write(s + "|"));
            Console.WriteLine();
            MyConsole.PrintLine("\nBye");
        }
    }
}
