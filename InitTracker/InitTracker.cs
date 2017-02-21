using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InitTracker
{
    public partial class InitTracker : Form
    {
        private CombatManager combat = new CombatManager();
        private BindingList<Character> playerList = new BindingList<Character>();


        // Initialization
        public InitTracker()
        {
            InitializeComponent();
            playerListBox.DataSource = playerList;
            playerListBox.DisplayMember = "Name";
        }

        // Input Validation
        private void validateNameInput()
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && (!string.IsNullOrWhiteSpace(nameTextBox.Text)) && (nameTextBox.Text.Length >= 3))
            {
                initValue.Enabled = true;
                initModValue.Enabled = true;
            }
            else
            {
                initValue.Enabled = false;
                addPlayerBtn.Enabled = false;
            }
        }

        private void validateInitInput()
        {
            if ((initValue.Value) != 0 && (!string.IsNullOrEmpty(initValue.Text)))
            {
                addPlayerBtn.Enabled = true;
            }
            else
            {
                addPlayerBtn.Enabled = false;
            }
        }

        private void validateInitModInput()
        {
            if (!string.IsNullOrEmpty(initModValue.Text))
            {
                addPlayerBtn.Enabled = true;
            }
            else
            {
                addPlayerBtn.Enabled = false;
            }
        }

        // Event Handlers
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            validateNameInput();

        }

        private void initValue_TextChanged(object sender, EventArgs e)
        {
            validateInitInput();

        }

        private void initValue_KeyUp(object sender, KeyEventArgs e)
        {
            validateInitInput();
        }

        private void initValue_Enter(object sender, EventArgs e)
        {
            initValue.Select(0, initValue.Text.Length);
        }

        private void initModValue_Enter(object sender, EventArgs e)
        {
            initModValue.Select(0, initModValue.Text.Length);
        }

        private void initModValue_TextChanged(object sender, EventArgs e)
        {
            validateInitModInput();

        }

        private void initModValue_KeyUp(object sender, KeyEventArgs e)
        {
            validateInitModInput();
        }

        private void startCombatBtn_Click(object sender, EventArgs e)
        {
            if (combat.GetPlayerCount() < 2)
            {
                MessageBox.Show("Please add at least 2 players!");
            }
            else
            {
                combat.StartCombat();
                endCombatBtn.Enabled = true;
                startCombatBtn.Enabled = false;
                currentPlayerTxt.Text = combat.GetActivePlayer().ToString();
                nextPlayerTxt.Text = combat.GetNextPlayer().ToString();
                turnCountTxt.Text = combat.GetTurns().ToString();
                nextPlayerBtn.Enabled = true;
                clearListBtn.Enabled = false;
            }
        }

        private void nextPlayerBtn_click(object sender, EventArgs e)
        {
            combat.NextPlayer();
            currentPlayerTxt.Text = combat.GetActivePlayer().ToString();
            nextPlayerTxt.Text = combat.GetNextPlayer().ToString();
            turnCountTxt.Text = combat.GetTurns().ToString();
        }

        private void endCombatBtn_Click(object sender, EventArgs e)
        {
            clearListBtn.Enabled = true;
            startCombatBtn.Enabled = true;
            combat.EndCombat();
            turnCountTxt.Text = "0";
            LastCombatTurntxt.Text = combat.GetLastTurnCount().ToString();
        }

        //Add Actor Event Handler
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            
            Character newPlayer = new Character(nameTextBox.Text, Convert.ToInt32(initValue.Value), Convert.ToInt32(initModValue.Value));
            if (!combat.AddPlayer(newPlayer))
            {
                MessageBox.Show("Error Adding Player! (Is it already there?)");
            }
            else
            {
                updatePlayerList();
                nameTextBox.Text = "";
                initValue.Value = 0;
                initValue.Enabled = false;
                initModValue.Value = 0;
                initModValue.Enabled = false;
                addPlayerBtn.Enabled = false;
                if (playerListBox.Items.Count > 0)
                {
                    delPlayerBtn.Enabled = true;
                }
                nameTextBox.Focus();
            }          
        }

        private void updatePlayerList()
        {
            combat.SortPlayers();
            playerList.Clear();
            foreach (Character a in combat.GetPlayers())
            {
                playerList.Add(a);
            }
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("End combat and clear the list?", "Are you Sure?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Clear Player list Box
                playerList.Clear();
                // Clear Combat related stuff
                currentPlayerTxt.Clear();
                nextPlayerTxt.Clear();
                turnCountTxt.Clear();
                nextPlayerBtn.Enabled = false;
                combat.ClearCombat();

                // Clear Add player stuff
                nameTextBox.Text = "";
                initValue.Value = 0;
                initValue.Enabled = false;
                initModValue.Enabled = false;
                initModValue.Value = 0;
                addPlayerBtn.Enabled = false;
                startCombatBtn.Enabled = false;
                endCombatBtn.Enabled = false;
                nameTextBox.Focus();
                delPlayerBtn.Enabled = false;

            }
        }

        private void delPlayerBtn_Click(object sender, EventArgs e)
        {
            if ( playerListBox.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select an Character first!");
            }
            else
            {
                combat.RemovePlayer(playerList.ElementAt(playerListBox.SelectedIndex));
                updatePlayerList();        
            }
       
        }
    }
}
