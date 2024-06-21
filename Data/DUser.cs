using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
	public class DUser
	{
		private int accountNumber;
		private string name;
		private string phone;

		public int AccountNumber { get => accountNumber; set => accountNumber = value; }
		public string Name { get => name; set => name = value; }
		public string Phone { get => phone; set => phone = value; }

		public DUser() { }

		public DUser(int accountNumber, string name, string phone)
		{
			AccountNumber = accountNumber;
			Name = name;
			Phone = phone;
		}
	}
}
