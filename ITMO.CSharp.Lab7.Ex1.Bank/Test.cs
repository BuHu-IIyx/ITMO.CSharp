using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab7.Ex1.Bank
{
    class Test
    {
        static void Main(string[] args)
        {
            BankAccount firstBankAcc = new BankAccount();
            firstBankAcc.Populate(100);
            BankAccount secondBankAcc = new BankAccount();
            secondBankAcc.Populate(100);
            Write(firstBankAcc);
            Write(secondBankAcc);
            firstBankAcc.TransferFrom(secondBankAcc, 10);
            Console.WriteLine("After transfer:");
            Console.WriteLine("Balance first account: {0}, Balance second account: {1}", firstBankAcc.Balance(), secondBankAcc.Balance());
        }
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("№ {0}: {1}$ ({2})", toWrite.Number(), toWrite.Balance(), toWrite.Type());
        }
    }
}
