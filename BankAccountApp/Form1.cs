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
				new BankAccount { Owner = "Elon Musk", AccountNumber = Guid.NewGuid(), Balance = 9999 },
				new BankAccount { Owner = "Bill Gates", AccountNumber = Guid.NewGuid(), Balance = 150 }
			};

			BankAccountsGrid.DataSource = bankAccounts; // No ambiguity now
		}
	}
}