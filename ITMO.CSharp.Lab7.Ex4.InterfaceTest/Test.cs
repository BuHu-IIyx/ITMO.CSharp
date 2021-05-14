using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab7.Ex4.InterfaceTest
{
    /// <summary>
    ///   This the test harness
    /// </summary>
    class Test
    {
        static void Main(string[] args)
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
            Console.WriteLine("String: {0}", Utils.IsItFormattable(s));
        }        
    }
}
