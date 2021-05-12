using System;

namespace ITMO.CSharp.Lab6.FromLecture
{
    class Triangle
    {
        public double a, b, c;
        
        public double Perimeter ()
        {
            double perimeter = a + b + c;
            return perimeter;            
        }
        
        public double Area ()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public void PrintParametrs ()
        {
            Console.WriteLine("Side A = {0}", a);
            Console.WriteLine("Side B = {0}", b);
            Console.WriteLine("Side C = {0}", c);
            Console.WriteLine("Perimeter = {0}", Perimeter());
            Console.WriteLine("Area = {0}", Area());
        }
    }
}
