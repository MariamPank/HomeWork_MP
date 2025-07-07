using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        private string _transactionType;
        private string _ccy;
        private decimal _amount;

        public string TransactionType
        { 
            get { return _transactionType; } 
            set 
            { 
                if (value == null || (value != "Withdrawal" && value != "Deposit")) 
                { 
                    throw new ArgumentException("Transaction type must be either 'Withdrawal' or 'Deposit'"); 
                } 
                _transactionType = value; 
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

        public decimal Amount
        {
            get { return _amount; }

            set { 
                if (value <= 0 && _transactionType == "Deposit")
                {
                    throw new ArgumentException("Deposit amount must be greater than zero");
                }
                if (value >= 0 && _transactionType == "Withdrawal")
                {
                    throw new ArgumentException("Withdrawn amount must be less than zero");
                }
                _amount = value;
            }
        }
    }
}
