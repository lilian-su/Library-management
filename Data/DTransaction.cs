using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MauiApp2.Data
{
    public class DTransaction
    {
        public int AccountNumber { get; set; }
        public int Isbn { get; set; }
        public string Action { get; set; }
        public DateTime DateTimeChecked { get; set; }

        public DTransaction() { }

        public DTransaction(int accountNumber, int isbn, string action, DateTime dateTimeChecked)
        {
            AccountNumber = accountNumber;
            Isbn = isbn;
            Action = action;// check in or check out in user history table database
            DateTimeChecked = dateTimeChecked;
        }
    }
}

