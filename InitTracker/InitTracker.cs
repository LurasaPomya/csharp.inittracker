using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InitTracker
{
    public partial class InitTracker : Form
    {
        private CombatManager combat = new CombatManager();

        // Initialization
        public InitTracker()
        {
            InitializeComponent();
        }

        // Input Validation
        private void validateNameInput()
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrWhiteSpace(nameTextBox.Text) && nameTextBox.Text.Length >= 3)
            {
                initValue.Enabled = true;
            }
            else
            {
                initValue.Enabled = false;
                addPlayerBtn.Enabled = false;
            }
        }

        private void validateInitInput()
        {
            if (initValue.Value != 0 && !string.IsNullOrEmpty(initValue.Text))
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
            /* TODO Use new class for this
            startCombatBtn.Enabled = true;
            endCombatBtn.Enabled = false;
            currentPlayerTxt.Text = "";
            nextPlayerTxt.Text = "";
            nextPlayerBtn.Enabled = false;
            clearListBtn.Enabled = true;
            */
        }

        //Add Actor Event Handler
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            
            Actor newPlayer = new Actor(nameTextBox.Text, Convert.ToInt32(initValue.Value));
            if (!combat.AddPlayer(newPlayer))
            {
                MessageBox.Show("Error Adding Player! (Is it already there?)");
            }
            else
            {
                combat.SortPlayers();
                playerListBox.BeginUpdate();
                playerListBox.Items.Clear();
                foreach (Actor a in combat.GetPlayers())
                {
                    playerListBox.Items.Add(a.ToString());
                }
                playerListBox.EndUpdate();
                nameTextBox.Text = "";
                initValue.Value = 0;
                initValue.Enabled = false;
                addPlayerBtn.Enabled = false;
                nameTextBox.Focus();
            }          
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("End combat and clear the list?", "Are you Sure?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Clear Player list Box
                playerListBox.Items.Clear();
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
                addPlayerBtn.Enabled = false;
                startCombatBtn.Enabled = false;
                endCombatBtn.Enabled = false;
                nameTextBox.Focus();

            }
        }
    }
}
