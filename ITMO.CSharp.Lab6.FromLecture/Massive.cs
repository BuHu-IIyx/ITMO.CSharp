using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab6.FromLecture
{
    class Massive
    {
        public int[] intArray;
        public int n;

        public Massive()
        {
            this.IniMassive();
        }
        public void IniMassive()        //Инициализация массива
        {
            Console.Write("Enter the number of items: ");
            n = int.Parse(Console.ReadLine());
            intArray = new int[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write("/nEnter the {0} element: ", (i+1));
                intArray[i]= int.Parse(Console.ReadLine());
            }
        }
        public void PrintMassive()      //Вывод на экран элементов массива
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
            Console.WriteLine();
        }
        public int midMassive()         //Расчет среднего значения массива
        {
            int mid;
            int sum = intArray.Sum();
            mid = sum/n;
            return mid;
        }
        public void SortMassive()      //Сортировка массива
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (intArray[i - 1] > intArray[i])
                {
                    int temp = intArray[i - 1];
                    intArray[i - 1] = intArray[i];
                    intArray[i] = temp;
                    count++;
                }
            }
            if (count != 0)
            {
                this.SortMassive();
            }
            else
            {
                return;
            }
        }
    }
}
