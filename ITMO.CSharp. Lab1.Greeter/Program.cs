using System;

namespace ITMO.CSharp._Lab1.Greeter
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
        }
    }
}
