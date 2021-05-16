using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankTransaction
{
    //
    //Свойства
    //
    private readonly decimal amount;
    private readonly DateTime when;
    //
    //Конструктор
    //
    public BankTransaction(decimal amount)
    {
        this.amount = amount;
        when = DateTime.Now;
    }
    //
    //Методы
    //
    public decimal Amount()
    {
        return amount;
    }
    public DateTime When()
    {
        return when;
    }
}

