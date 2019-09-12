namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBoxOne = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.adddTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.teamsPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deletSelectedPrizes = new System.Windows.Forms.Button();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentNameLabel
            // 
            this.createTournamentNameLabel.AutoSize = true;
            this.createTournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.createTournamentNameLabel.Location = new System.Drawing.Point(30, 106);
            this.createTournamentNameLabel.Name = "createTournamentNameLabel";
            this.createTournamentNameLabel.Size = new System.Drawing.Size(316, 47);
            this.createTournamentNameLabel.TabIndex = 9;
            this.createTournamentNameLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBoxOne
            // 
            this.tournamentNameTextBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameTextBoxOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameTextBoxOne.ForeColor = System.Drawing.Color.Navy;
            this.tournamentNameTextBoxOne.Location = new System.Drawing.Point(39, 225);
            this.tournamentNameTextBoxOne.Name = "tournamentNameTextBoxOne";
            this.tournamentNameTextBoxOne.Size = new System.Drawing.Size(256, 43);
            this.tournamentNameTextBoxOne.TabIndex = 10;
            this.tournamentNameTextBoxOne.TextChanged += new System.EventHandler(this.TournamentNameTextBoxOne_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.Navy;
            this.entryFeeLabel.Location = new System.Drawing.Point(32, 305);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.EntryFeeLabel_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeValue.ForeColor = System.Drawing.Color.Navy;
            this.entryFeeValue.Location = new System.Drawing.Point(163, 303);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(132, 43);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            this.entryFeeValue.TextChanged += new System.EventHandler(this.EntryFeeValue_TextChanged);
            // 
            // selectComboBox
            // 
            this.selectComboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(39, 418);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(256, 45);
            this.selectComboBox.TabIndex = 14;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectComboBox_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.ForeColor = System.Drawing.Color.Navy;
            this.selectTeamLabel.Location = new System.Drawing.Point(32, 378);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.SelectTeamLabel_Click);
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(214, 392);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(81, 20);
            this.createNewTeamLinkLabel.TabIndex = 15;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "create new";
            this.createNewTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLinkLabel_LinkClicked);
            // 
            // adddTeamButton
            // 
            this.adddTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.adddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.adddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddTeamButton.Location = new System.Drawing.Point(53, 492);
            this.adddTeamButton.Name = "adddTeamButton";
            this.adddTeamButton.Size = new System.Drawing.Size(215, 50);
            this.adddTeamButton.TabIndex = 16;
            this.adddTeamButton.Text = "Add Team";
            this.adddTeamButton.UseVisualStyleBackColor = false;
            this.adddTeamButton.Click += new System.EventHandler(this.AdddTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Location = new System.Drawing.Point(53, 558);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(215, 50);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // teamsPlayersListBox
            // 
            this.teamsPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamsPlayersListBox.FormattingEnabled = true;
            this.teamsPlayersListBox.ItemHeight = 37;
            this.teamsPlayersListBox.Location = new System.Drawing.Point(460, 225);
            this.teamsPlayersListBox.Name = "teamsPlayersListBox";
            this.teamsPlayersListBox.Size = new System.Drawing.Size(349, 226);
            this.teamsPlayersListBox.TabIndex = 18;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.tournamentNameLabel.Location = new System.Drawing.Point(32, 185);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 19;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.Navy;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(453, 185);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(191, 37);
            this.tournamentPlayersLabel.TabIndex = 20;
            this.tournamentPlayersLabel.Text = "Teams/ Players";
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(828, 225);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(215, 50);
            this.deleteSelectedPlayersButton.TabIndex = 21;
            this.deleteSelectedPlayersButton.Text = "Delete Selected";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            // 
            // deletSelectedPrizes
            // 
            this.deletSelectedPrizes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deletSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deletSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.deletSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletSelectedPrizes.Location = new System.Drawing.Point(828, 595);
            this.deletSelectedPrizes.Name = "deletSelectedPrizes";
            this.deletSelectedPrizes.Size = new System.Drawing.Size(215, 50);
            this.deletSelectedPrizes.TabIndex = 24;
            this.deletSelectedPrizes.Text = "Delete Selected";
            this.deletSelectedPrizes.UseVisualStyleBackColor = false;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeLabel.ForeColor = System.Drawing.Color.Navy;
            this.prizeLabel.Location = new System.Drawing.Point(453, 475);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(85, 37);
            this.prizeLabel.TabIndex = 23;
            this.prizeLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(460, 515);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(349, 226);
            this.prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Location = new System.Drawing.Point(376, 781);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(399, 50);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournamnent";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2000, 881);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletSelectedPrizes);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.teamsPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.adddTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBoxOne);
            this.Controls.Add(this.createTournamentNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament Form";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label createTournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBoxOne;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.Button adddTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox teamsPlayersListBox;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deletSelectedPrizes;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}