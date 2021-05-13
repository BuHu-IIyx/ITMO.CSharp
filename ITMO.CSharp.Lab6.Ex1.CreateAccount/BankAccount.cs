using System;

namespace ITMO.CSharp.Lab6.CreateAccount
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        public void Populate(long accNo, decimal accBal)
        {
            this.accNo = accNo;
            this.accBal = accBal;
            accType = AccountType.Checking;
        }

        public long Number()
        {
            return accNo;
        }

        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            string type = accType.ToString();
            return type;
        }
    }
}
