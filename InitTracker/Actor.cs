using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitTracker
{
    class Actor
    {
        public String Name { get; set; }
        public int Initiative { get; set; }

        public Actor(string newName, int newInit)
        {
            Name = newName;
            Initiative = newInit;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
