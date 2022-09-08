using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Person
    {
        //fields
        string password;
        readonly string SIN;

        //properties
        public bool isAuthenticated { get; private set; }
        public string Name { get; private set; }

        //constructor
        public Person(string name, string sin)
        {
            this.Name = name;
            this.SIN = sin;
            this.password = SIN.Substring(0, 3);
        }

        public void Login(string password)
        {
            try
            {
                if (!(this.password == password))
                {
                    throw new AccountException();
                }

                else
                {
                    isAuthenticated = true;
                }
            }
            catch (AccountException e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Logout()
        {
            isAuthenticated = false;
        }

        //override
        public override string ToString()
        {
            return $"{this.Name} --- {(this.isAuthenticated == true? "Authenticated" : "Not Authenticated" )}";
        }

        //exceptions
    }
}
