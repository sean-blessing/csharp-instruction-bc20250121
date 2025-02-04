namespace Chap04Ex0202GradeConverter {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Grade Converter App!");

            String choice = "y";
            // upper or lowercase y is ok
            //while (choice == "y" || choice == "Y") {
            while (choice.ToLower() == "y") {
                // prompt for input - numericGrade: int
                Console.Write("Enter numeric grade: ");
                //int numericGrade = Convert.ToInt32(Console.ReadLine());
                int numericGrade = Int32.Parse(Console.ReadLine());
                // do business logic
                String letterGrade = "";
                if (numericGrade >= 88)
                    letterGrade = "A";
                else if (numericGrade >= 80)
                    letterGrade = "B";
                else if (numericGrade >= 68)
                    letterGrade = "C";
                else if (numericGrade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";
                // display result - display letterGrade
                Console.WriteLine("Letter grade: " + letterGrade);

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye");
        }
    }
}
