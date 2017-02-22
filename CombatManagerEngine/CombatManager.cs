using System;
using System.Collections.Generic;
using System.Linq;

namespace InitTracker
{
    public class CombatManager
    {

        private Boolean status; // Status of Combat
        private int turns; // Turn count
        private int lastTurnCount;
        private int activePlayerNum; // Active player in the list of players
        private List<Character> playerList; // List of players in the form of an Actor class

        // Constructor Method(s)
        public CombatManager()
        {
            playerList = new List<Character>();
            status = false;
            turns = 1;
            lastTurnCount = 0;
        }

        // Clears combat. Essentially like End Combat, but End combat doesn't clear the player list.
        public void ClearCombat()
        {
            playerList.Clear();
            status = false;
            lastTurnCount = turns;
            turns = 1;
            activePlayerNum = 0;

        }

        // Adds a player to the list. Checks for the current Actor already there.
        public Boolean AddPlayer(Character newPlayer)
        {
            Boolean exists = false;
            if (playerList.Count != 0)
            {
                foreach (Character a in playerList)
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

        private void checkForDupes()
        {
            Boolean noDupes = false;
            do
            {

            } while (!noDupes);
        }

        // Removes a player from the list.
        public Boolean RemovePlayer(Character delPlayer)
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
        public List<Character> GetPlayers()
        {
            return playerList;
        }

        // Get player count
        public int GetPlayerCount()
        {
            return playerList.Count;
        }

        // Get Active Player
        public Character GetActivePlayer()
        {
            return playerList.ElementAt(activePlayerNum);
        }

        // Get Next Player
        public Character GetNextPlayer()
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

        public void StartCombat()
        {
            turns = 1;
            activePlayerNum = 0;
            status = true;
        }

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
            playerList = playerList
                .OrderByDescending(a => a.Initiative)
                .ThenByDescending(a => a.Modifier)
                .ToList<Character>();
        }

        // Get list of player Names as string list
        public List<String> PlayerNames()
        {
            List<String> names = new List<String>();
            foreach (Character c in playerList)
            {
                names.Add(c.Name);
            }
            return names;
        }

        // Get List of Player inits as a list of Inits
        public List<int> PlayerInits()
        {
            List<int> inits = new List<int>();
            foreach (Character c in playerList)
            {
                inits.Add(c.Initiative);
            }
            return inits;
        }

        public List<int> PlayerMods()
        {
            List<int> mods = new List<int>();
            foreach (Character c in playerList)
            {
                mods.Add(c.Modifier);
            }
            return mods;
        }

    }

}
