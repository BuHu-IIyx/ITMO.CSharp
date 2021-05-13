using System;

namespace ITMO.CSharp.Lab7.Ex2.Utils
{
    class Test
    {
        static void Main(string[] args)
        {
            string someString;
            Console.WriteLine("Type text for reverse: ");
            someString = Console.ReadLine();

            Utils.Reverse(ref someString);

            Console.WriteLine(someString);
        }
    }
}
