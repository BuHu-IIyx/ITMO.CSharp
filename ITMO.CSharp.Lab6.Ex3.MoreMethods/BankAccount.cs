﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab6.MoreMethods
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;

        public decimal Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                accBal += amount;
            }
            return accBal;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }


        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public void Populate(decimal accBal)
        {
            this.accNo = NextNumber();
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
