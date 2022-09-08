using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public abstract class Account
    {
        //fields
        private static int CURRENT_NUMBER = 0;
        public readonly List<Transaction> transactions = new List<Transaction>();
        public readonly List<Person> holders = new List<Person>();
        public readonly string Number;

        //properties
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        //constructor
        public Account(string type, double balance)
        {
            
        }

        //methods
        public void AddUser(Person person) { }
        public void Deposit(double amount, Person person) { }
        public bool IsHolder(string name) { }
        public void PrepareMonthlyReport() { }


        //override
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
