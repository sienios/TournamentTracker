namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextBoxOne = new System.Windows.Forms.TextBox();
            this.createTeamNameLabel = new System.Windows.Forms.Label();
            this.adddTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBoxOne = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMembersButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.teamNameLabel.Location = new System.Drawing.Point(35, 144);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 22;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameTextBoxOne
            // 
            this.teamNameTextBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameTextBoxOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameTextBoxOne.ForeColor = System.Drawing.Color.Navy;
            this.teamNameTextBoxOne.Location = new System.Drawing.Point(42, 184);
            this.teamNameTextBoxOne.Name = "teamNameTextBoxOne";
            this.teamNameTextBoxOne.Size = new System.Drawing.Size(256, 43);
            this.teamNameTextBoxOne.TabIndex = 21;
            // 
            // createTeamNameLabel
            // 
            this.createTeamNameLabel.AutoSize = true;
            this.createTeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.createTeamNameLabel.Location = new System.Drawing.Point(33, 65);
            this.createTeamNameLabel.Name = "createTeamNameLabel";
            this.createTeamNameLabel.Size = new System.Drawing.Size(211, 47);
            this.createTeamNameLabel.TabIndex = 20;
            this.createTeamNameLabel.Text = "Create Team";
            // 
            // adddTeamMemberButton
            // 
            this.adddTeamMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adddTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.adddTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.adddTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddTeamMemberButton.Location = new System.Drawing.Point(41, 373);
            this.adddTeamMemberButton.Name = "adddTeamMemberButton";
            this.adddTeamMemberButton.Size = new System.Drawing.Size(266, 50);
            this.adddTeamMemberButton.TabIndex = 25;
            this.adddTeamMemberButton.Text = "Add Team Member";
            this.adddTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(41, 299);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(256, 45);
            this.selectTeamMemberComboBox.TabIndex = 24;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.Navy;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(34, 259);
            this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 23;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.emailTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.phoneTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.phoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameTextBoxOne);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(434, 65);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(390, 358);
            this.addNewMemberGroupBox.TabIndex = 26;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Location = new System.Drawing.Point(81, 302);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(215, 50);
            this.createMemberButton.TabIndex = 26;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Navy;
            this.emailTextBox.Location = new System.Drawing.Point(152, 224);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(193, 43);
            this.emailTextBox.TabIndex = 19;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.Navy;
            this.emailLabel.Location = new System.Drawing.Point(-7, 226);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 37);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Navy;
            this.phoneTextBox.Location = new System.Drawing.Point(152, 175);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(193, 43);
            this.phoneTextBox.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Navy;
            this.phoneLabel.Location = new System.Drawing.Point(-7, 177);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(92, 37);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Navy;
            this.lastNameTextBox.Location = new System.Drawing.Point(152, 126);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(193, 43);
            this.lastNameTextBox.TabIndex = 15;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.lastNameLabel.Location = new System.Drawing.Point(-7, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // firstNameTextBoxOne
            // 
            this.firstNameTextBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBoxOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextBoxOne.ForeColor = System.Drawing.Color.Navy;
            this.firstNameTextBoxOne.Location = new System.Drawing.Point(152, 77);
            this.firstNameTextBoxOne.Name = "firstNameTextBoxOne";
            this.firstNameTextBoxOne.Size = new System.Drawing.Size(193, 43);
            this.firstNameTextBoxOne.TabIndex = 13;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.firstNameLabel.Location = new System.Drawing.Point(-7, 79);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(42, 457);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(325, 263);
            this.teamMembersListBox.TabIndex = 27;
            // 
            // deleteSelectedMembersButton
            // 
            this.deleteSelectedMembersButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.deleteSelectedMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMembersButton.Location = new System.Drawing.Point(420, 471);
            this.deleteSelectedMembersButton.Name = "deleteSelectedMembersButton";
            this.deleteSelectedMembersButton.Size = new System.Drawing.Size(215, 50);
            this.deleteSelectedMembersButton.TabIndex = 28;
            this.deleteSelectedMembersButton.Text = "Delete Selected";
            this.deleteSelectedMembersButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Location = new System.Drawing.Point(255, 742);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(399, 50);
            this.createTeamButton.TabIndex = 29;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 881);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMembersButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.adddTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.teamNameTextBoxOne);
            this.Controls.Add(this.createTeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextBoxOne;
        private System.Windows.Forms.Label createTeamNameLabel;
        private System.Windows.Forms.Button adddTeamMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox firstNameTextBoxOne;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMembersButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}