using System;

namespace ITMO.CSharp.Lab5.MatrixMultiply
{
    class MatrixMultiply
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            Input(a);
            Input(b);
                        
            Output(Multiply (a,b));

            static void Input(int[,] matrix)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("Enter value for [{0},{1}] : ", i, j);
                        string s = Console.ReadLine();
                        matrix[i, j] = int.Parse(s);
                    }
                }
                Console.WriteLine();
            }


            static int[,] Multiply (int[,] a, int[,] b)
            {
                int[,] result = new int[2, 2];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] += a[i, 0] * b[0, j] + a[i, 1] * b[1, j];
                    }
                }

                return result;
            }
            
            static void Output(int[,] result)
            {
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write("{0} ", result[i, j]);
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
