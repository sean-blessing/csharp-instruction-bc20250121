using System.Collections;

namespace Chap08ExWizardInventory {
    internal class Program {
        static List<string> items = new List<string>();
        static void Main(string[] args) {
            PrintLine("Welcome to the Wizard Inventory Game!!!!\n");
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");
            string command = "";
            while (command != "exit") {
                DisplayMenu();
                Print("Command: ");
                command = Console.ReadLine().ToLower();
                switch (command) {
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    case "exit":
                        break;
                }
                PrintLine("");
            }

            PrintLine("Bye");
        }

        private static void DropItem() {
            PrintLine("Drop an Item:");
            PrintLine("-------------");
            int itemNumber = PromptInt("Item # to Drop: ", 1, items.Count);
            string itemName = items[itemNumber - 1];
            items.Remove(itemName);
            PrintLine($"{itemName} was removed.");
        }

        private static void EditItem() {
            PrintLine("Edit an Item:");
            PrintLine("-------------");
            int itemNumber = PromptInt("Item # to Edit: ", 1, items.Count);
            Print("Updated name: ");
            string updatedName = Console.ReadLine();
            items[itemNumber - 1] = updatedName;
            PrintLine($"Item number {itemNumber} was updated.");
        }

        private static void GrabItem() {
            PrintLine("Grab/Add an Item:");
            PrintLine("-----------------");
            if (items.Count >= 4) {
                PrintLine("Carrying too many items. Please drop one first.");
            }
            else {
                Print("Item to add: ");
                string itemName = Console.ReadLine();
                items.Add(itemName);
                PrintLine($"{itemName} was added.");
            }
        }

        private static void ShowItems() {
            PrintLine("Show All Items:");
            PrintLine("---------------");
            for (int i = 0; i < items.Count; i++) {
                PrintLine($"{i + 1}. {items[i]}");
            }
        }

        static void DisplayMenu() {
            PrintLine("COMMAND MENU");
            PrintLine("=======================");
            PrintLine("show - show all items");
            PrintLine("grab - grab/add an item");
            PrintLine("edit - edit an item");
            PrintLine("drop - drop an item");
            PrintLine("exit - exit the app");
        }

        static int PromptInt(string prompt, int min, int max) {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result)) {
                    if (result >= min && result <= max) {
                        isValid = true;
                    }
                    else {
                        PrintLine("Error - entry must be within range.");
                    }
                }
                else {
                    PrintLine("Error - entry must be a whole numer.");
                }
            }

            return result;
        }

        static void Print(string message) {
            Console.Write(message);
        }

        static void PrintLine(string message) {
            Console.WriteLine(message);
        }

    }
}
