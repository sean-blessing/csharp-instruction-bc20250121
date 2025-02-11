namespace Chap12ExContactList {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Contact List App!\n");

            string choice = "y";
            while (choice == "y") {
                // prompt firstName, lastName, email, phone
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email: ");
                string phone = MyConsole.PromptString("Enter phone: ");
                // create a Contact instance
                Contact c = new Contact(firstName, lastName, email, phone);
                // displayContact
                MyConsole.PrintLine(c.DisplayContact());
                // prompt continue
                choice = MyConsole.PromptString("Continue? (y/n): ").ToLower().Trim();
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
