namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournament = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBoxOne = new System.Windows.Forms.TextBox();
            this.scoreTextBoxTwo = new System.Windows.Forms.TextBox();
            this.scoreTwoTeamLabel = new System.Windows.Forms.Label();
            this.nameTwoTeam = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournament
            // 
            this.tournament.AutoSize = true;
            this.tournament.ForeColor = System.Drawing.Color.Navy;
            this.tournament.Location = new System.Drawing.Point(25, 24);
            this.tournament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournament.Name = "tournament";
            this.tournament.Size = new System.Drawing.Size(185, 45);
            this.tournament.TabIndex = 0;
            this.tournament.Text = "Turnament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.ForeColor = System.Drawing.Color.Navy;
            this.tournamentName.Location = new System.Drawing.Point(207, 24);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(140, 45);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.Navy;
            this.roundLabel.Location = new System.Drawing.Point(25, 99);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(115, 45);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedCheckBox.ForeColor = System.Drawing.Color.Navy;
            this.unplayedCheckBox.Location = new System.Drawing.Point(164, 162);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(209, 41);
            this.unplayedCheckBox.TabIndex = 3;
            this.unplayedCheckBox.Text = "Unplayed Only";
            this.unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundComboBox
            // 
            this.roundComboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(164, 99);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(209, 45);
            this.roundComboBox.TabIndex = 4;
            // 
            // matchupListBox
            // 
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(33, 256);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(349, 263);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.Color.Navy;
            this.teamOneName.Location = new System.Drawing.Point(458, 256);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(165, 37);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.Navy;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(458, 304);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // scoreTextBoxOne
            // 
            this.scoreTextBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreTextBoxOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTextBoxOne.ForeColor = System.Drawing.Color.Navy;
            this.scoreTextBoxOne.Location = new System.Drawing.Point(566, 304);
            this.scoreTextBoxOne.Name = "scoreTextBoxOne";
            this.scoreTextBoxOne.Size = new System.Drawing.Size(193, 43);
            this.scoreTextBoxOne.TabIndex = 9;
            // 
            // scoreTextBoxTwo
            // 
            this.scoreTextBoxTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreTextBoxTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTextBoxTwo.ForeColor = System.Drawing.Color.Navy;
            this.scoreTextBoxTwo.Location = new System.Drawing.Point(566, 451);
            this.scoreTextBoxTwo.Name = "scoreTextBoxTwo";
            this.scoreTextBoxTwo.Size = new System.Drawing.Size(193, 43);
            this.scoreTextBoxTwo.TabIndex = 12;
            // 
            // scoreTwoTeamLabel
            // 
            this.scoreTwoTeamLabel.AutoSize = true;
            this.scoreTwoTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTwoTeamLabel.ForeColor = System.Drawing.Color.Navy;
            this.scoreTwoTeamLabel.Location = new System.Drawing.Point(458, 451);
            this.scoreTwoTeamLabel.Name = "scoreTwoTeamLabel";
            this.scoreTwoTeamLabel.Size = new System.Drawing.Size(82, 37);
            this.scoreTwoTeamLabel.TabIndex = 11;
            this.scoreTwoTeamLabel.Text = "Score";
            // 
            // nameTwoTeam
            // 
            this.nameTwoTeam.AutoSize = true;
            this.nameTwoTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTwoTeam.ForeColor = System.Drawing.Color.Navy;
            this.nameTwoTeam.Location = new System.Drawing.Point(458, 403);
            this.nameTwoTeam.Name = "nameTwoTeam";
            this.nameTwoTeam.Size = new System.Drawing.Size(165, 37);
            this.nameTwoTeam.TabIndex = 10;
            this.nameTwoTeam.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versusLabel.ForeColor = System.Drawing.Color.Navy;
            this.versusLabel.Location = new System.Drawing.Point(592, 366);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 37);
            this.versusLabel.TabIndex = 13;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.DarkGray;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(811, 354);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(132, 56);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // teamTwoName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 705);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.scoreTextBoxTwo);
            this.Controls.Add(this.scoreTwoTeamLabel);
            this.Controls.Add(this.nameTwoTeam);
            this.Controls.Add(this.scoreTextBoxOne);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.tournament);
            this.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "teamTwoName";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournament;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox scoreTextBoxOne;
        private System.Windows.Forms.TextBox scoreTextBoxTwo;
        private System.Windows.Forms.Label scoreTwoTeamLabel;
        private System.Windows.Forms.Label nameTwoTeam;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

