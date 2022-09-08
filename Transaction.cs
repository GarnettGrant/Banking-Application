using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public struct Transaction
    {
        //properties
        public string AccountNumber { get; }
        public double Amount { get; }
        public double EndBalance { get; }
        public Person Originator { get; }
        public DateTime Time { get; }

        //constructor
        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        {
            this.AccountNumber = accountNumber;
            this.Amount = amount;
            this.EndBalance = endBalance;
            this.Originator = person;
            this.Time = time;
        }

        //methods

        //override
        public override string ToString()
        {
            return $"{this.AccountNumber} --- {this.Originator.Name} --- {this.Amount} --- {this.Time.ToShortTimeString()} --- Withdraw/Deposit";//Edit to display withdraw/deposit appropriately
        }

    }
}
