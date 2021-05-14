using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab7.Ex5.TestDisplay
{
    public class Test
    {
        public static void Main()
        {
            int num = 65;
            string msg = "A String";
            Coordinate c = new Coordinate(21.0, 68.0);

            Utils.Display(num);
            Utils.Display(msg);
            Utils.Display(c);
        }
    }
}
