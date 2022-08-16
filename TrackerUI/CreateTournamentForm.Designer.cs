﻿namespace TrackerUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
			this.headerLabel = new System.Windows.Forms.Label();
			this.tournamentNameValue = new System.Windows.Forms.TextBox();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.entryFeeValue = new System.Windows.Forms.TextBox();
			this.entryFeeLabel = new System.Windows.Forms.Label();
			this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamLabel = new System.Windows.Forms.Label();
			this.createNewTeanLink = new System.Windows.Forms.LinkLabel();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
			this.tournamentPlayersLabel = new System.Windows.Forms.Label();
			this.prizesLabel = new System.Windows.Forms.Label();
			this.prizesListBox = new System.Windows.Forms.ListBox();
			this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
			this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(25, 34);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(317, 50);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(38, 137);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(304, 35);
			this.tournamentNameValue.TabIndex = 10;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.tournamentNameLabel.Location = new System.Drawing.Point(29, 97);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
			this.tournamentNameLabel.TabIndex = 9;
			this.tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(161, 207);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(181, 35);
			this.entryFeeValue.TabIndex = 12;
			this.entryFeeValue.Text = "0";
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.entryFeeLabel.Location = new System.Drawing.Point(30, 207);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
			this.entryFeeLabel.TabIndex = 11;
			this.entryFeeLabel.Text = "Entry Fee";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(38, 342);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(304, 38);
			this.selectTeamDropDown.TabIndex = 14;
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.selectTeamLabel.Location = new System.Drawing.Point(29, 302);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
			this.selectTeamLabel.TabIndex = 13;
			this.selectTeamLabel.Text = "Select Team";
			// 
			// createNewTeanLink
			// 
			this.createNewTeanLink.AutoSize = true;
			this.createNewTeanLink.Location = new System.Drawing.Point(228, 308);
			this.createNewTeanLink.Name = "createNewTeanLink";
			this.createNewTeanLink.Size = new System.Drawing.Size(114, 30);
			this.createNewTeanLink.TabIndex = 15;
			this.createNewTeanLink.TabStop = true;
			this.createNewTeanLink.Text = "create new";
			// 
			// addTeamButton
			// 
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addTeamButton.Location = new System.Drawing.Point(97, 400);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(191, 42);
			this.addTeamButton.TabIndex = 16;
			this.addTeamButton.Text = "Add Team";
			this.addTeamButton.UseVisualStyleBackColor = true;
			this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createPrizeButton.Location = new System.Drawing.Point(97, 457);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(191, 42);
			this.createPrizeButton.TabIndex = 17;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			// 
			// tournamentTeamsListBox
			// 
			this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tournamentTeamsListBox.FormattingEnabled = true;
			this.tournamentTeamsListBox.ItemHeight = 30;
			this.tournamentTeamsListBox.Location = new System.Drawing.Point(475, 137);
			this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
			this.tournamentTeamsListBox.Size = new System.Drawing.Size(318, 152);
			this.tournamentTeamsListBox.TabIndex = 18;
			// 
			// tournamentPlayersLabel
			// 
			this.tournamentPlayersLabel.AutoSize = true;
			this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.tournamentPlayersLabel.Location = new System.Drawing.Point(468, 96);
			this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
			this.tournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
			this.tournamentPlayersLabel.TabIndex = 19;
			this.tournamentPlayersLabel.Text = "Teams / Players";
			// 
			// prizesLabel
			// 
			this.prizesLabel.AutoSize = true;
			this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.prizesLabel.Location = new System.Drawing.Point(468, 306);
			this.prizesLabel.Name = "prizesLabel";
			this.prizesLabel.Size = new System.Drawing.Size(85, 37);
			this.prizesLabel.TabIndex = 21;
			this.prizesLabel.Text = "Prizes";
			// 
			// prizesListBox
			// 
			this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.prizesListBox.FormattingEnabled = true;
			this.prizesListBox.ItemHeight = 30;
			this.prizesListBox.Location = new System.Drawing.Point(475, 347);
			this.prizesListBox.Name = "prizesListBox";
			this.prizesListBox.Size = new System.Drawing.Size(318, 152);
			this.prizesListBox.TabIndex = 20;
			// 
			// removeSelectedPlayersButton
			// 
			this.removeSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.removeSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedPlayersButton.Location = new System.Drawing.Point(825, 178);
			this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
			this.removeSelectedPlayersButton.Size = new System.Drawing.Size(160, 70);
			this.removeSelectedPlayersButton.TabIndex = 22;
			this.removeSelectedPlayersButton.Text = "Remove Selected";
			this.removeSelectedPlayersButton.UseVisualStyleBackColor = true;
			// 
			// removeSelectedPrizeButton
			// 
			this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedPrizeButton.Location = new System.Drawing.Point(825, 388);
			this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
			this.removeSelectedPrizeButton.Size = new System.Drawing.Size(160, 70);
			this.removeSelectedPrizeButton.TabIndex = 24;
			this.removeSelectedPrizeButton.Text = "Remove Selected";
			this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentButton.Location = new System.Drawing.Point(357, 582);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(282, 69);
			this.createTournamentButton.TabIndex = 27;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1052, 696);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.removeSelectedPrizeButton);
			this.Controls.Add(this.removeSelectedPlayersButton);
			this.Controls.Add(this.prizesLabel);
			this.Controls.Add(this.prizesListBox);
			this.Controls.Add(this.tournamentPlayersLabel);
			this.Controls.Add(this.tournamentTeamsListBox);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.addTeamButton);
			this.Controls.Add(this.createNewTeanLink);
			this.Controls.Add(this.selectTeamDropDown);
			this.Controls.Add(this.selectTeamLabel);
			this.Controls.Add(this.entryFeeValue);
			this.Controls.Add(this.entryFeeLabel);
			this.Controls.Add(this.tournamentNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeanLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button removeSelectedPlayersButton;
        private Button removeSelectedPrizeButton;
        private Button createTournamentButton;
    }
}