using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_OOPBank
{
    public class Bank
    {
        private decimal _balance;
        public Bank(decimal balance)
        {
            _balance = balance;
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
