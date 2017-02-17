using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitTracker
{
    class CombatManager
    {

        private Boolean status; // Status of Combat
        private int turns; // Turn count
        private int lastTurnCount;
        private int activePlayerNum; // Active player in the list of players
        private List<Actor> playerList; // List of players in the form of an Actor class

        // Constructor Method(s)
        // TODO Consider adding a method of importing a playerlist?
        public CombatManager()
        {
            playerList = new List<Actor>();
            status = false;
            turns = 1;
            lastTurnCount = 0;
        }

        // Clears combat. Essentially like End Combat, but End combat doesn't clear the player list.
        // TODO Update end combat function to just do this, but with an optional variable to set clear. EndCombat(false/true)
        public void ClearCombat()
        {
            playerList.Clear();
            status = false;
            lastTurnCount = turns;
            turns = 1;
            activePlayerNum = 0;

        }

        // Adds a player to the list. Checks for the current Actor already there.
        // TODO Use custom exception maybe when it's bad input? For now just returns false
        // TODO Check for duplicate inits. Or perhaps stop using duplicate inits? As once combat starts, it's just order. Ponder this for a while.
        public Boolean AddPlayer(Actor newPlayer)
        {
            Boolean exists = false;
            if (playerList.Count != 0)
            {
                foreach (Actor a in playerList)
                {
                    if (newPlayer.Name == a.Name)
                    {
                        exists = true;
                    }
                }
            }
            if (!exists)
            {
                playerList.Add(newPlayer);
                return true;
            }
            else { return false; }
        }

        // Removes a player from the list.
        // TODO Use custom exception or return ID if we go that route.
        public Boolean RemovePlayer(Actor delPlayer)
        {
            if (playerList.Remove(delPlayer))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Get List of Players
        public List<Actor> GetPlayers()
        {
            return playerList;
        }

        // Get player count
        public int GetPlayerCount()
        {
            return playerList.Count;
        }

        // Get Active Player
        public Actor GetActivePlayer()
        {
            return playerList.ElementAt(activePlayerNum);
        }

        // Get Next Player
        public Actor GetNextPlayer()
        {
            if ((activePlayerNum + 1) >= playerList.Count)
            {
                return playerList.ElementAt(0);
            }
            else
            {
                return playerList.ElementAt(activePlayerNum + 1);
            }
        }

        // TODO finish start combat
        public void StartCombat()
        {
            turns = 1;
            activePlayerNum = 0;
            status = true;
        }

        // TODO Finish end combat
        public void EndCombat()
        {
            status = false;
            lastTurnCount = turns;
            turns = 0;
            activePlayerNum = 0;

        }
        
        public int GetTurns()
        {
            return turns;
        }

        // Get status of combat
        public Boolean GetCombatStatus()
        {
            return status;
        }

        // Incriment active player.
        // TODO Add custom exception
        public Boolean NextPlayer()
        {
            if (status == true) // Ensures combat is actually active.
            {
                if ((activePlayerNum + 1) < playerList.Count)
                {
                    activePlayerNum++;
                }
                else
                {
                    activePlayerNum = 0;
                    turns++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get last combat turn count
        public int GetLastTurnCount()
        {
            return lastTurnCount;
        }

        // Sort Players by Initiative Scores
        public void SortPlayers()
        {
            playerList = playerList.OrderBy(a => a.Initiative).ToList<Actor>();
            playerList.Reverse();
        }
        // TODO Get list of player names
        // TODO Get list of player inits
    }

}
