using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab6.FromLecture
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Test triangle:");
            Triangle Treugolnik = new Triangle();
            Treugolnik.a = 10;
            Treugolnik.b = 5;
            Treugolnik.c = 6;
            Treugolnik.PrintParametrs();
            
            Console.WriteLine();
            Console.WriteLine("Create massive:");
            Massive test = new Massive();
            //test.IniMassive();
            test.PrintMassive();
            double testMid = test.midMassive();
            Console.WriteLine(testMid);
            test.SortMassive();
            test.PrintMassive();

        }
    }
}
