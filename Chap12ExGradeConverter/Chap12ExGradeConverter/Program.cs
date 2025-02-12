using ConsoleUtil;

namespace Chap12ExGradeConverter {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the grade converter!\n");

            string choice = "y";
            while (choice == "y") {
                int numericGrade = MyConsole.PromptInt("Enter numerical grade: ", 0, 100);
                Grade grade = new Grade(numericGrade);
                //Grade grade = new Grade();
                //grade.Number = numericGrade;
                MyConsole.PrintLine("Letter grade: " + grade.GetLetter());
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n").ToLower();
            }
            MyConsole.PrintLine("bye");
        }
    }
}
