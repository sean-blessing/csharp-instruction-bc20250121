using Chap14ExPersonManager.Model;
using ConsoleUtil;

namespace Chap14ExPersonManager.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Person Manager!\n");

            string choice = "y";
            while (choice == "y")
            {
                string personType = MyConsole.PromptReqString("Create customer or employee (c/e): ", "c", "e");
                string firstName = MyConsole.PromptString("First name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                Person p;
                if (personType == "c") {
                    string customerNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lastName, customerNumber);
                    p = c;
                }
                else
                {
                    string ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p = e;
                }
                MyConsole.PrintLine("");
                MyConsole.PrintLine("You entered a new "+p.GetType().Name+":");
                MyConsole.PrintLine(p.ToString());
                
                // print person summary
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }
            MyConsole.PrintLine("bye!");
        }
    }
}
