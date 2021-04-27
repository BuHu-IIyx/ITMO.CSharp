using System;

namespace ITMO.CSharp.Lab2.StructType
{
    class Struct
    {
        public enum AccountType { Checking, Deposit };
        public struct BankAccount 
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance ${0}", goldAccount.accBal);
        }
    }
}
