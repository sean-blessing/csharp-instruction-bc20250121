using System.Runtime.CompilerServices;

namespace Chap12ExContactList {
    public class Contact {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact(string FirstName, string LastName, string Email, string Phone) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Phone.ToString();
        }

        public string DisplayContact() {
            string displayStr = "----------------------------------------------\n";
            displayStr += "---------- Current Contact ----------------------\n";
            displayStr += "-------------------------------------------------\n";
            displayStr += "Name:                " + this.FirstName + " " + this.LastName + "\n";
            displayStr += "Email Address:       " + this.Email + "\n";
            displayStr += "Phone Number:        " + this.Phone + "\n";
            displayStr += "-------------------------------------------------\n";
            return displayStr;
        }


    }
}
