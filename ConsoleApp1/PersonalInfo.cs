using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonalInfo
    {
        private string _personalId;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account Account { get; set; }
        public string PersonalID
        {
            get { return _personalId; }
            set
            {
                if (value.Length == 11)
                {
                    _personalId = value;
                }
                else
                {
                    throw new ArgumentException("The ID must be 11 characters long");
                }
            }
        }

        public PersonalInfo(string firstName, string lastName, decimal balance, string accountNumber, string ccy, string personalId)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalID = personalId;

            Account = new Account
            {
                Balance = balance,
                AccountNumber = accountNumber,
                Ccy = ccy
            };
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }
            if (Account.Balance < amount)
            {
                throw new ArgumentException("Insufficient funds for withdrawal");
            }
            Account.Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero");
            }
            Account.Balance += amount;
        }

        public void Transfer(decimal amount, PersonalInfo recipient)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Transfer amount must be greater than zero");
            }
            if (Account.Balance < amount)
            {
                throw new ArgumentException("Insufficient funds for transfer");
            }
            Account.Balance -= amount;
            recipient.Account.Balance += amount;
        }

    }
}
