using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankAccountApp
{
	public class BankAccount
	{
		public int MemberID { get; set; } // Added to store the primary key
		public string Owner { get; set; }
		public Guid AccountNumber { get; set; }
		public decimal Balance { get; set; }

		private string connectionString = "Server=RDELROSARIO-22\\SQLEXPRESS02; Initial Catalog=BankAccount; Trusted_Connection=True;";

		// Method to register a new bank account
		public void Reg(string owner, Guid accountNumber, decimal balance)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string sql = "INSERT INTO BankMember(Owner, AccountNumber, Balance) VALUES (@Owner, @AccountNumber, @Balance)";

				try
				{
					con.Open();
					SqlCommand cmd = new SqlCommand(sql, con);

					// Use parameters passed to the method
					cmd.Parameters.AddWithValue("@Owner", owner);
					cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
					cmd.Parameters.AddWithValue("@Balance", balance);

					cmd.ExecuteNonQuery();
					Console.WriteLine("Bank account registered successfully.");
				}
				catch (SqlException ex)
				{
					Console.WriteLine("SQL Error: " + ex.Message);
				}
			}
		}

		// Method to retrieve all bank accounts
		public List<BankAccount> GetBankAccounts()
		{
			List<BankAccount> bankAccounts = new List<BankAccount>();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM BankMember";

				try
				{
					con.Open();
					SqlCommand cmd = new SqlCommand(sql, con);
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						BankAccount account = new BankAccount
						{
							MemberID = (int)dr["MemberID"], // Map MemberID to the class property
							Owner = dr["Owner"].ToString(),
							AccountNumber = (Guid)dr["AccountNumber"],
							Balance = (decimal)dr["Balance"]
						};

						bankAccounts.Add(account);
					}
				}
				catch (SqlException ex)
				{
					Console.WriteLine("SQL Error: " + ex.Message);
				}
			}

			return bankAccounts;
		}
	}
}