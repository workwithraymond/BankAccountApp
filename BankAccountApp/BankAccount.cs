using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
	public class BankAccount
	{
		public string Owner {  get; set; }
		public Guid AccountNumber { get; set; }
		public decimal Balance { get; set; }

		public void Reg(string owner, Guid accountNumber, decimal balance)
		{
			SqlConnection con = new SqlConnection("Server=RDELROSARIO-22\\SQLEXPRESS02; Initial Catalog=BankAccount; Trusted_Connection=True;");

			string sql = "INSERT INTO BankMember(Owner, AccountNumber, Balance) values (@Owner, @AccountNumber, @Balance)";

			try
			{
				con.Open();

				SqlCommand cmd = new SqlCommand(sql, con);

				cmd.Parameters.AddWithValue("@Owner", Owner);
				cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
				cmd.Parameters.AddWithValue("@Balance", Balance);

				cmd.ExecuteNonQuery();

			}
			catch (SqlException ex) 
			{
				Console.WriteLine("SQL Error: " + ex.Message);
			}

		}

	}
}
