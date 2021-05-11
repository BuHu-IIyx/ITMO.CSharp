using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab4.Utility
{
    
    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());               // запрос ввода первого значения
            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());               // запрос ввода второго значения
            int greater = Utils.Greater(x, y);                   // вызов метода Greater  
            Console.WriteLine("The greater value: {0}", greater);    // вывод в консоль большего числа

            Console.WriteLine();   // разделение между функциями

            Console.WriteLine("Before swap: x:{0}, y:{1}", x, y);
            Utils.Swap(ref x, ref y);                               // вызов метода Swap
            Console.WriteLine("After swap: x:{0}, y:{1}", x, y);

            Console.WriteLine();   // разделение между функциями

            int factorial;
            Console.Write("Enter integer for factorial: ");
            int z = int.Parse(Console.ReadLine());          //запрос ввода
            bool ok = Utils.Factorial(z, out factorial);
            if(ok)                                          //проверка выполнения и вывод результата
            {
                Console.WriteLine("Factorial {0} equal to {1}", z, factorial);
            }
            else
            {
                Console.WriteLine("I can't calculate the factorial of the number {0}", z);
            }
        }
    }
}
