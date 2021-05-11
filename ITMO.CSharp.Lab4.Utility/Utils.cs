using System;

namespace ITMO.CSharp.Lab4.Utility
{
    
    public class Utils
    {
        public static int Greater(int a, int b) //Возвращает большее число из 2-х
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static void Swap(ref int a, ref int b) // Меняет местами 2 числа
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer) //расчет факториала
        {
            int result = 1;
            bool check = true;
            if (n > 0)          //если положительное число считаем факториал
            {
                try
                {
                    checked         //проверка на переполнение
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            result = result * i;
                        }
                    }
                }
                catch (System.OverflowException)
                {
                    result = 0;
                    check = false;
                }
            }
            else if(n == 0)        //если "0" возвращаем "0"
            {
                result = 1;
            }
            else                    //все остальное ошибка
            {
                check = false;
            }
            answer = result; //запись результата
            return check;
        }
    }
}
