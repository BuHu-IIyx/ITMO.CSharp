using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab8.Ex3.Finalizers
{
    sealed class BankAccount : IDisposable
    {
        //
        //Свойства
        //
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        private Queue<BankTransaction> tranQueue = new Queue<BankTransaction>();
        public bool disposed = false;
        //
        //Конструкторы
        //
        public BankAccount()
        {
            accNo = NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
        }
        public BankAccount(AccountType accType)
        {
            accNo = NextNumber();
            accBal = 0;
            this.accType = accType;
        }
        public BankAccount(decimal accBal)
        {
            accNo = NextNumber();
            this.accBal = accBal;
            accType = AccountType.Checking;
        }
        public BankAccount(AccountType accType, decimal accBal)
        {
            accNo = NextNumber();
            this.accBal = accBal;
            this.accType = accType;
        }
        //
        //Деструктор
        //
        ~BankAccount()
        {
            Dispose();
        }
        //
        //Методы
        //
        public void Dispose()
        {
            if (!disposed)
            {
                StreamWriter swFile = File.AppendText("Transactions.txt");
                swFile.WriteLine("Account number is {0}", accNo);
                swFile.WriteLine("Account balance is {0}", accBal);
                swFile.WriteLine("Account type is {0}", accType);
                swFile.WriteLine("Transactions:");
                foreach (BankTransaction tran in tranQueue)
                {
                    swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
                }
                swFile.Close();
                disposed = true;
                GC.SuppressFinalize(this);
            }

        }
        public Queue<BankTransaction> Transactions()
        {
            return tranQueue;
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
            {
                this.Deposit(amount);
            }
        }
        public decimal Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                accBal += amount;
                BankTransaction tran = new BankTransaction(amount);
                tranQueue.Enqueue(tran);
            }
            return accBal;
        }
        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }
        private static long NextNumber()
        {
            return nextAccNo++;
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
