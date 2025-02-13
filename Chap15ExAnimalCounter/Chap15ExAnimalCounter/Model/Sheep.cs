using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15ExAnimalCounter.Model {
    internal class Sheep : Animal {
        public string Name { get; set; }
        public override string GetCountString() {
            return Count + " " + Name;
        }
    }
}
