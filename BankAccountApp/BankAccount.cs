﻿using System;
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
	}
}
