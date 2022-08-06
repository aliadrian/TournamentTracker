﻿namespace TrackerUI
{
	partial class CreatePrizeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
			this.headerLabel = new System.Windows.Forms.Label();
			this.placeNumberValue = new System.Windows.Forms.TextBox();
			this.placeNumberLabel = new System.Windows.Forms.Label();
			this.prizePercentageValue = new System.Windows.Forms.TextBox();
			this.prizePercentageLabel = new System.Windows.Forms.Label();
			this.prizeAmountValue = new System.Windows.Forms.TextBox();
			this.prizeAmountLabel = new System.Windows.Forms.Label();
			this.placeNameValue = new System.Windows.Forms.TextBox();
			this.placeNameLabel = new System.Windows.Forms.Label();
			this.orLabel = new System.Windows.Forms.Label();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(22, 28);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(209, 50);
			this.headerLabel.TabIndex = 11;
			this.headerLabel.Text = "Create Prize";
			// 
			// placeNumberValue
			// 
			this.placeNumberValue.Location = new System.Drawing.Point(260, 112);
			this.placeNumberValue.Name = "placeNumberValue";
			this.placeNumberValue.Size = new System.Drawing.Size(214, 35);
			this.placeNumberValue.TabIndex = 24;
			// 
			// placeNumberLabel
			// 
			this.placeNumberLabel.AutoSize = true;
			this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.placeNumberLabel.Location = new System.Drawing.Point(40, 112);
			this.placeNumberLabel.Name = "placeNumberLabel";
			this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
			this.placeNumberLabel.TabIndex = 23;
			this.placeNumberLabel.Text = "Place Number";
			this.placeNumberLabel.Click += new System.EventHandler(this.placeNumberLabel_Click);
			// 
			// prizePercentageValue
			// 
			this.prizePercentageValue.Location = new System.Drawing.Point(260, 359);
			this.prizePercentageValue.Name = "prizePercentageValue";
			this.prizePercentageValue.Size = new System.Drawing.Size(214, 35);
			this.prizePercentageValue.TabIndex = 26;
			this.prizePercentageValue.Text = "0";
			// 
			// prizePercentageLabel
			// 
			this.prizePercentageLabel.AutoSize = true;
			this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.prizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.prizePercentageLabel.Location = new System.Drawing.Point(40, 359);
			this.prizePercentageLabel.Name = "prizePercentageLabel";
			this.prizePercentageLabel.Size = new System.Drawing.Size(214, 37);
			this.prizePercentageLabel.TabIndex = 25;
			this.prizePercentageLabel.Text = "Prize percentage";
			// 
			// prizeAmountValue
			// 
			this.prizeAmountValue.Location = new System.Drawing.Point(260, 222);
			this.prizeAmountValue.Name = "prizeAmountValue";
			this.prizeAmountValue.Size = new System.Drawing.Size(214, 35);
			this.prizeAmountValue.TabIndex = 28;
			this.prizeAmountValue.Text = "0";
			// 
			// prizeAmountLabel
			// 
			this.prizeAmountLabel.AutoSize = true;
			this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.prizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.prizeAmountLabel.Location = new System.Drawing.Point(40, 222);
			this.prizeAmountLabel.Name = "prizeAmountLabel";
			this.prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
			this.prizeAmountLabel.TabIndex = 27;
			this.prizeAmountLabel.Text = "Prize Amount";
			// 
			// placeNameValue
			// 
			this.placeNameValue.Location = new System.Drawing.Point(260, 167);
			this.placeNameValue.Name = "placeNameValue";
			this.placeNameValue.Size = new System.Drawing.Size(214, 35);
			this.placeNameValue.TabIndex = 30;
			// 
			// placeNameLabel
			// 
			this.placeNameLabel.AutoSize = true;
			this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.placeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.placeNameLabel.Location = new System.Drawing.Point(40, 167);
			this.placeNameLabel.Name = "placeNameLabel";
			this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
			this.placeNameLabel.TabIndex = 29;
			this.placeNameLabel.Text = "Place Name";
			// 
			// orLabel
			// 
			this.orLabel.AutoSize = true;
			this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.orLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.orLabel.Location = new System.Drawing.Point(223, 288);
			this.orLabel.Name = "orLabel";
			this.orLabel.Size = new System.Drawing.Size(64, 37);
			this.orLabel.TabIndex = 31;
			this.orLabel.Text = "-or-";
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createPrizeButton.Location = new System.Drawing.Point(120, 453);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(282, 69);
			this.createPrizeButton.TabIndex = 32;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
			// 
			// CreatePrizeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(532, 579);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.orLabel);
			this.Controls.Add(this.placeNameValue);
			this.Controls.Add(this.placeNameLabel);
			this.Controls.Add(this.prizeAmountValue);
			this.Controls.Add(this.prizeAmountLabel);
			this.Controls.Add(this.prizePercentageValue);
			this.Controls.Add(this.prizePercentageLabel);
			this.Controls.Add(this.placeNumberValue);
			this.Controls.Add(this.placeNumberLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "CreatePrizeForm";
			this.Text = "Create Prize";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label headerLabel;
		private TextBox placeNumberValue;
		private Label placeNumberLabel;
		private TextBox prizePercentageValue;
		private Label prizePercentageLabel;
		private TextBox prizeAmountValue;
		private Label prizeAmountLabel;
		private TextBox placeNameValue;
		private Label placeNameLabel;
		private Label orLabel;
		private Button createPrizeButton;
	}
}