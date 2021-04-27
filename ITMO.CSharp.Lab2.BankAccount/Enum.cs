using System;

namespace ITMO.CSharp
{
    class Perechislenie
    {
        public enum AccountType { checking, deposit };
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.checking;
            platinumAccount = AccountType.deposit;
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}