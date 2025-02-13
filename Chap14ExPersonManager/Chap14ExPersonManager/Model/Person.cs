﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14ExPersonManager.Model {
    internal class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName) { 
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string ToString() {
            return $"Name: {FirstName} {LastName}\n";
        }
    }
}
