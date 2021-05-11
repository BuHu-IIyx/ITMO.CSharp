using System;
using System.IO;

namespace ITMO.CSharp.Lab4.FileDetails
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            long size = stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            //foreach (char ch in contents)
            //{
            //    Console.Write(ch);
            //}
            //StreamReader.Close;
            Summarize(contents);

        }
        static  void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0, numbers = 0, other = 0;
            string vowelsLetters = "AEIOUaeiou";
            string numbersAll = "0123456789";
            string consonantsLetters = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if (vowelsLetters.IndexOf(current) != -1) //счетчик гласных
                    {
                        vowels++;
                    }
                    else if (consonantsLetters.IndexOf(current) != -1) //счетчик согласных
                    {
                        consonants++;
                    }
                    else if(numbersAll.IndexOf(current) != -1) //счетчик цифр
                    {
                        numbers++;
                    }
                    else  //счетчик всего остального
                    {
                        other++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);

        }
    }
}
