using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InitTracker
{
    public partial class InitTracker : Form
    {
        //Variables we need
        private List<Actor> playerList = new List<Actor>();
        List<string> playerListString = new List<string>();
        private int currentPlayerPos = 0;
        private int turnCount = 1;

        //Initialization
        public InitTracker()
        {
            InitializeComponent();
        }

        //Input Validation
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

        //Event Handlers
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
            turnCount = 0;
            turnCountTxt.Text = turnCount.ToString();

            startCombatBtn.Enabled = false;
            endCombatBtn.Enabled = true;
            nextPlayerBtn.Enabled = true;
            clearListBtn.Enabled = false;

            currentPlayerTxt.Text = playerListString[currentPlayerPos];
            nextPlayerTxt.Text = playerListString[currentPlayerPos + 1];
        }

        private void nextPlayerBtn_click(object sender, EventArgs e)
        {

            if (currentPlayerPos == -1)
            {
                turnCount++;
                turnCountTxt.Text = turnCount.ToString();
            }
            currentPlayerPos++;
            if (currentPlayerPos < playerListString.Count - 1)
            {
                currentPlayerTxt.Text = playerListString[currentPlayerPos];
                nextPlayerTxt.Text = playerListString[currentPlayerPos + 1];
            }
            else
            {
                currentPlayerTxt.Text = playerListString[currentPlayerPos];
                nextPlayerTxt.Text = playerListString[0];
                currentPlayerPos = -1;
            }
        }

        private void endCombatBtn_Click(object sender, EventArgs e)
        {
            startCombatBtn.Enabled = true;
            endCombatBtn.Enabled = false;
            currentPlayerTxt.Text = "";
            nextPlayerTxt.Text = "";
            nextPlayerBtn.Enabled = false;
            clearListBtn.Enabled = true;
        }

        //Add Actor Event Handler
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            playerList.Add(new Actor(nameTextBox.Text, (int)initValue.Value));
            playerList = playerList.OrderBy(i => i.Initiative).ToList();
            playerList.Reverse();

            playerListString = playerList.Select(n => n.Name).ToList();
            playerListBox.DataSource = playerListString;
            nameTextBox.Text = "";
            initValue.Value = 0;
            nameTextBox.Focus();
            initValue.Enabled = false;
            addPlayerBtn.Enabled = false;
            clearListBtn.Enabled = true;
            if (playerList.Count >= 2)
            {
                startCombatBtn.Enabled = true;
            }
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            playerListString.Clear();
            playerList.Clear();
            playerListBox.Items.Clear();
            clearListBtn.Enabled = false;
        }
    }
}
