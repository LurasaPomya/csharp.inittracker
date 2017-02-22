using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitTracker
{
    public class Character
    {
        public String Name { get; set; }
        public int Initiative { get; set; }

        public int Modifier { get; set; } // Current simple solution to set who goes first when inits match. (This would be replaced by a dex bonus of an actualy character sheet)

        public Character(string newName, int newInit, int newMod)
        {
            Name = newName;
            Initiative = newInit;
            Modifier = newMod;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
