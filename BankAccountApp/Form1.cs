using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BankAccountApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Example usage of BankAccountsGrid without redeclaring it.
			List<BankAccount> bankAccounts = new List<BankAccount>
			{
				new BankAccount { Owner = "Raymond Del Rosario", AccountNumber = Guid.NewGuid(), Balance = 250 },
				new BankAccount { Owner = "Donald Trump", AccountNumber = Guid.NewGuid(), Balance = 9999 },
				new BankAccount { Owner = "Kamala Harris", AccountNumber = Guid.NewGuid(), Balance = 150 }
			};

			BankAccountsGrid.DataSource = bankAccounts; // No ambiguity now
		}

		private void CreateAccountBtn_Click(object sender, EventArgs e)
		{
			BankAccount bb = new BankAccount();
			bb.Reg(OwnerTxt.Text);
			MessageBox.Show("Record Added");
		}
	}
}