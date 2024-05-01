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
        public decimal Deposit(decimal x)
        {
            _balance += x;
            return _balance;
        }
        public decimal Withdraw(decimal x)
        {
            if (x > 500)
                x = 500;
            if (x > _balance)
                x = _balance;
            _balance -= x;
            return _balance;
        }
        public decimal Balance
        {
            get { return _balance; }
        }
    }
}
