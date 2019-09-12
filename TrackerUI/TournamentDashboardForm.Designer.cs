namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.createPrizeNameLabel = new System.Windows.Forms.Label();
            this.loadTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.selectTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeNameLabel
            // 
            this.createPrizeNameLabel.AutoSize = true;
            this.createPrizeNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.createPrizeNameLabel.Location = new System.Drawing.Point(173, 63);
            this.createPrizeNameLabel.Name = "createPrizeNameLabel";
            this.createPrizeNameLabel.Size = new System.Drawing.Size(387, 47);
            this.createPrizeNameLabel.TabIndex = 22;
            this.createPrizeNameLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentComboBox
            // 
            this.loadTournamentComboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTournamentComboBox.FormattingEnabled = true;
            this.loadTournamentComboBox.Location = new System.Drawing.Point(181, 195);
            this.loadTournamentComboBox.Name = "loadTournamentComboBox";
            this.loadTournamentComboBox.Size = new System.Drawing.Size(379, 45);
            this.loadTournamentComboBox.TabIndex = 25;
            // 
            // selectTournamentLabel
            // 
            this.selectTournamentLabel.AutoSize = true;
            this.selectTournamentLabel.ForeColor = System.Drawing.Color.Navy;
            this.selectTournamentLabel.Location = new System.Drawing.Point(251, 142);
            this.selectTournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTournamentLabel.Name = "selectTournamentLabel";
            this.selectTournamentLabel.Size = new System.Drawing.Size(235, 37);
            this.selectTournamentLabel.TabIndex = 26;
            this.selectTournamentLabel.Text = "Select Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Location = new System.Drawing.Point(181, 246);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(379, 50);
            this.loadTournamentButton.TabIndex = 31;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentName
            // 
            this.createTournamentName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createTournamentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentName.Location = new System.Drawing.Point(181, 374);
            this.createTournamentName.Name = "createTournamentName";
            this.createTournamentName.Size = new System.Drawing.Size(379, 50);
            this.createTournamentName.TabIndex = 32;
            this.createTournamentName.Text = "Create Tournament";
            this.createTournamentName.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 465);
            this.Controls.Add(this.createTournamentName);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.selectTournamentLabel);
            this.Controls.Add(this.loadTournamentComboBox);
            this.Controls.Add(this.createPrizeNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeNameLabel;
        private System.Windows.Forms.ComboBox loadTournamentComboBox;
        private System.Windows.Forms.Label selectTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentName;
    }
}