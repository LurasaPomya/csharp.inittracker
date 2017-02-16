namespace InitTracker
{
    partial class InitTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitTracker));
            this.addPlayerBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.initLabel = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.initValue = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endCombatBtn = new System.Windows.Forms.Button();
            this.startCombatBtn = new System.Windows.Forms.Button();
            this.currentPlayerlbl = new System.Windows.Forms.Label();
            this.currentPlayerTxt = new System.Windows.Forms.TextBox();
            this.nextPlayerTxt = new System.Windows.Forms.TextBox();
            this.nextPlayerlbl = new System.Windows.Forms.Label();
            this.turnCountLbl = new System.Windows.Forms.Label();
            this.turnCountTxt = new System.Windows.Forms.TextBox();
            this.nextPlayerBtn = new System.Windows.Forms.Button();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.lastTurnCountLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPlayerBtn
            // 
            this.addPlayerBtn.Enabled = false;
            this.addPlayerBtn.Location = new System.Drawing.Point(263, 98);
            this.addPlayerBtn.Name = "addPlayerBtn";
            this.addPlayerBtn.Size = new System.Drawing.Size(75, 23);
            this.addPlayerBtn.TabIndex = 3;
            this.addPlayerBtn.Text = "Add Player";
            this.addPlayerBtn.UseVisualStyleBackColor = true;
            this.addPlayerBtn.Click += new System.EventHandler(this.addPlayerBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(263, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(260, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Character Name:";
            // 
            // initLabel
            // 
            this.initLabel.AutoSize = true;
            this.initLabel.Location = new System.Drawing.Point(263, 55);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(24, 13);
            this.initLabel.TabIndex = 4;
            this.initLabel.Text = "Init:";
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(6, 3);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.playerListBox.Size = new System.Drawing.Size(251, 199);
            this.playerListBox.TabIndex = 6;
            this.playerListBox.TabStop = false;
            // 
            // initValue
            // 
            this.initValue.Enabled = false;
            this.initValue.Location = new System.Drawing.Point(263, 72);
            this.initValue.Name = "initValue";
            this.initValue.Size = new System.Drawing.Size(75, 20);
            this.initValue.TabIndex = 2;
            this.initValue.ValueChanged += new System.EventHandler(this.initValue_TextChanged);
            this.initValue.Enter += new System.EventHandler(this.initValue_Enter);
            this.initValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.initValue_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.endCombatBtn);
            this.panel1.Controls.Add(this.startCombatBtn);
            this.panel1.Controls.Add(this.initValue);
            this.panel1.Controls.Add(this.playerListBox);
            this.panel1.Controls.Add(this.initLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.addPlayerBtn);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 215);
            this.panel1.TabIndex = 7;
            // 
            // endCombatBtn
            // 
            this.endCombatBtn.Enabled = false;
            this.endCombatBtn.Location = new System.Drawing.Point(263, 172);
            this.endCombatBtn.Name = "endCombatBtn";
            this.endCombatBtn.Size = new System.Drawing.Size(100, 23);
            this.endCombatBtn.TabIndex = 8;
            this.endCombatBtn.TabStop = false;
            this.endCombatBtn.Text = "End Combat";
            this.endCombatBtn.UseVisualStyleBackColor = true;
            this.endCombatBtn.Click += new System.EventHandler(this.endCombatBtn_Click);
            // 
            // startCombatBtn
            // 
            this.startCombatBtn.Location = new System.Drawing.Point(263, 143);
            this.startCombatBtn.Name = "startCombatBtn";
            this.startCombatBtn.Size = new System.Drawing.Size(100, 23);
            this.startCombatBtn.TabIndex = 7;
            this.startCombatBtn.TabStop = false;
            this.startCombatBtn.Text = "Start Combat";
            this.startCombatBtn.UseVisualStyleBackColor = true;
            this.startCombatBtn.Click += new System.EventHandler(this.startCombatBtn_Click);
            // 
            // currentPlayerlbl
            // 
            this.currentPlayerlbl.AutoSize = true;
            this.currentPlayerlbl.Location = new System.Drawing.Point(13, 254);
            this.currentPlayerlbl.Name = "currentPlayerlbl";
            this.currentPlayerlbl.Size = new System.Drawing.Size(76, 13);
            this.currentPlayerlbl.TabIndex = 8;
            this.currentPlayerlbl.Text = "Current Player:";
            // 
            // currentPlayerTxt
            // 
            this.currentPlayerTxt.Enabled = false;
            this.currentPlayerTxt.Location = new System.Drawing.Point(95, 251);
            this.currentPlayerTxt.Name = "currentPlayerTxt";
            this.currentPlayerTxt.Size = new System.Drawing.Size(143, 20);
            this.currentPlayerTxt.TabIndex = 9;
            this.currentPlayerTxt.TabStop = false;
            // 
            // nextPlayerTxt
            // 
            this.nextPlayerTxt.Enabled = false;
            this.nextPlayerTxt.Location = new System.Drawing.Point(95, 306);
            this.nextPlayerTxt.Name = "nextPlayerTxt";
            this.nextPlayerTxt.Size = new System.Drawing.Size(143, 20);
            this.nextPlayerTxt.TabIndex = 11;
            this.nextPlayerTxt.TabStop = false;
            // 
            // nextPlayerlbl
            // 
            this.nextPlayerlbl.AutoSize = true;
            this.nextPlayerlbl.Location = new System.Drawing.Point(25, 309);
            this.nextPlayerlbl.Name = "nextPlayerlbl";
            this.nextPlayerlbl.Size = new System.Drawing.Size(64, 13);
            this.nextPlayerlbl.TabIndex = 10;
            this.nextPlayerlbl.Text = "Next Player:";
            // 
            // turnCountLbl
            // 
            this.turnCountLbl.AutoSize = true;
            this.turnCountLbl.Location = new System.Drawing.Point(26, 364);
            this.turnCountLbl.Name = "turnCountLbl";
            this.turnCountLbl.Size = new System.Drawing.Size(63, 13);
            this.turnCountLbl.TabIndex = 12;
            this.turnCountLbl.Text = "Turn Count:";
            // 
            // turnCountTxt
            // 
            this.turnCountTxt.Enabled = false;
            this.turnCountTxt.Location = new System.Drawing.Point(95, 361);
            this.turnCountTxt.Name = "turnCountTxt";
            this.turnCountTxt.Size = new System.Drawing.Size(143, 20);
            this.turnCountTxt.TabIndex = 13;
            this.turnCountTxt.TabStop = false;
            // 
            // nextPlayerBtn
            // 
            this.nextPlayerBtn.Enabled = false;
            this.nextPlayerBtn.Location = new System.Drawing.Point(95, 277);
            this.nextPlayerBtn.Name = "nextPlayerBtn";
            this.nextPlayerBtn.Size = new System.Drawing.Size(100, 23);
            this.nextPlayerBtn.TabIndex = 9;
            this.nextPlayerBtn.TabStop = false;
            this.nextPlayerBtn.Text = "Next Player";
            this.nextPlayerBtn.UseVisualStyleBackColor = true;
            this.nextPlayerBtn.Click += new System.EventHandler(this.nextPlayerBtn_click);
            // 
            // clearListBtn
            // 
            this.clearListBtn.Location = new System.Drawing.Point(272, 426);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(100, 23);
            this.clearListBtn.TabIndex = 14;
            this.clearListBtn.TabStop = false;
            this.clearListBtn.Text = "Clear List";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // lastTurnCountLbl
            // 
            this.lastTurnCountLbl.AutoSize = true;
            this.lastTurnCountLbl.Location = new System.Drawing.Point(16, 426);
            this.lastTurnCountLbl.Name = "lastTurnCountLbl";
            this.lastTurnCountLbl.Size = new System.Drawing.Size(125, 13);
            this.lastTurnCountLbl.TabIndex = 15;
            this.lastTurnCountLbl.Text = "Last Combat Turn Count:";
            // 
            // InitTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lastTurnCountLbl);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.nextPlayerBtn);
            this.Controls.Add(this.turnCountTxt);
            this.Controls.Add(this.turnCountLbl);
            this.Controls.Add(this.nextPlayerTxt);
            this.Controls.Add(this.nextPlayerlbl);
            this.Controls.Add(this.currentPlayerTxt);
            this.Controls.Add(this.currentPlayerlbl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "InitTracker";
            this.Text = "Dec\'s GM Tools Init Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.initValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPlayerBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label initLabel;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.NumericUpDown initValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentPlayerlbl;
        private System.Windows.Forms.TextBox currentPlayerTxt;
        private System.Windows.Forms.TextBox nextPlayerTxt;
        private System.Windows.Forms.Label nextPlayerlbl;
        private System.Windows.Forms.Label turnCountLbl;
        private System.Windows.Forms.TextBox turnCountTxt;
        private System.Windows.Forms.Button endCombatBtn;
        private System.Windows.Forms.Button startCombatBtn;
        private System.Windows.Forms.Button nextPlayerBtn;
        private System.Windows.Forms.Button clearListBtn;
        private System.Windows.Forms.Label lastTurnCountLbl;
    }
}

