using System;
using System.IO;

namespace ITMO.CSharp.Lab7.Ex3.CopyFileUpper
{
    /// <summary>
    ///    Class to create an upper case copy of a file
    /// </summary>
    class CopyFileUpper
    {
        static void Main(string[] args)
        {
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;
            Console.WriteLine("Copy from:");
            sFrom = Console.ReadLine();
            Console.WriteLine("Copy to:");
            sTo = Console.ReadLine();
            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);
                while (srFrom.Peek() != -1)
                {
                    string Buffer = srFrom.ReadLine();
                    Buffer = Buffer.ToUpper();
                    swTo.WriteLine(Buffer);
                }
                swTo.Close();
                srFrom.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Check adress and try again.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something wrong. Check all and try again.");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
