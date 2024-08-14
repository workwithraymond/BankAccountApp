﻿namespace BankAccountApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			OwnerTxt = new TextBox();
			AmountNum = new NumericUpDown();
			BankAccountsGrid = new DataGridView();
			DepositBtn = new Button();
			WithdrawBtn = new Button();
			CreateAccountBtn = new Button();
			((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(99, 86);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(113, 45);
			label1.TabIndex = 0;
			label1.Text = "Owner";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(99, 575);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(135, 45);
			label2.TabIndex = 1;
			label2.Text = "Amount";
			// 
			// OwnerTxt
			// 
			OwnerTxt.Location = new Point(235, 86);
			OwnerTxt.Name = "OwnerTxt";
			OwnerTxt.Size = new Size(348, 50);
			OwnerTxt.TabIndex = 2;
			// 
			// AmountNum
			// 
			AmountNum.Location = new Point(242, 575);
			AmountNum.Name = "AmountNum";
			AmountNum.Size = new Size(341, 50);
			AmountNum.TabIndex = 3;
			// 
			// BankAccountsGrid
			// 
			BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BankAccountsGrid.Location = new Point(691, 94);
			BankAccountsGrid.Name = "BankAccountsGrid";
			BankAccountsGrid.RowHeadersWidth = 62;
			BankAccountsGrid.Size = new Size(874, 531);
			BankAccountsGrid.TabIndex = 4;
			// 
			// DepositBtn
			// 
			DepositBtn.Location = new Point(691, 679);
			DepositBtn.Name = "DepositBtn";
			DepositBtn.Size = new Size(343, 66);
			DepositBtn.TabIndex = 5;
			DepositBtn.Text = "Deposit";
			DepositBtn.UseVisualStyleBackColor = true;
			// 
			// WithdrawBtn
			// 
			WithdrawBtn.Location = new Point(1118, 679);
			WithdrawBtn.Name = "WithdrawBtn";
			WithdrawBtn.Size = new Size(316, 66);
			WithdrawBtn.TabIndex = 6;
			WithdrawBtn.Text = "Withdraw";
			WithdrawBtn.UseVisualStyleBackColor = true;
			// 
			// CreateAccountBtn
			// 
			CreateAccountBtn.Location = new Point(235, 186);
			CreateAccountBtn.Name = "CreateAccountBtn";
			CreateAccountBtn.Size = new Size(341, 56);
			CreateAccountBtn.TabIndex = 7;
			CreateAccountBtn.Text = "Create account";
			CreateAccountBtn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(18F, 45F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1610, 798);
			Controls.Add(CreateAccountBtn);
			Controls.Add(WithdrawBtn);
			Controls.Add(DepositBtn);
			Controls.Add(BankAccountsGrid);
			Controls.Add(AmountNum);
			Controls.Add(OwnerTxt);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
			((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox OwnerTxt;
		private NumericUpDown AmountNum;
		private DataGridView BankAccountsGrid;
		private Button DepositBtn;
		private Button WithdrawBtn;
		private Button CreateAccountBtn;
	}
}
