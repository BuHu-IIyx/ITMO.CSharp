using System;

namespace ITMO.CSharp.Lab7.Ex5.TestDisplay
{
    class Coordinate : IPrintable
    {
		private double x;
		private double y;

		public Coordinate()
		{
			x = 0.0;
			y = 0.0;
		}

		public Coordinate(double px, double py)
		{
			x = px;
			y = py;
		}

		public void Print()
		{
			Console.WriteLine("({0},{1})", x, y);
		}
	}
}
