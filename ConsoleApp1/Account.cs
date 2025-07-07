using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        private decimal _balance;
        private string _accountNumber;
        private string _ccy;

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                _balance = value;
            }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (value == null || value.Length != 22)
                {
                    throw new ArgumentException("Account number must be 22 characters long");
                }
                _accountNumber = value;
            }
        }

        public string Ccy
        {
            get { return _ccy; }
            set
            {
                if (value == null || value.Length != 3)
                {
                    throw new ArgumentException("Currency code must be 3 characters long");
                }
                _ccy = value;
            }
        }
    }
}
