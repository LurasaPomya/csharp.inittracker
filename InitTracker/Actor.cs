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

        public int priority { get; set; } // Current simple solution to set who goes first when inits match. (This would be replaced by a dex bonus of an actualy character sheet)

        public Actor(string newName, int newInit)
        {
            Name = newName;
            Initiative = newInit;
            priority = 0;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
