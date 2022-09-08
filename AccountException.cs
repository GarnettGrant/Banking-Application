using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class AccountException : Exception
    {
        //fields
        const string ACCOUNT_DOES_NOT_EXIST = "This account does not exist";
        const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "Your credit limit has been exceeded";
        const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "This name is not associated with this account";
        const string NO_OVERDRAFT = "This account does not have overdraft";
        const string PASSWORD_INCORRECT = "The password you enterred is incorrect";
        const string USER_DOES_NOT_EXIST = "This user does not exist";
        const string USER_NOT_LOGGED_IN = "User not logged in";

        //constructor
        public AccountException()
        {

        }

        public AccountException(string reason)
        {

        }
    }
}
