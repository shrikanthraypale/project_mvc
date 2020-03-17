using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingDelegate
{
    class Swapping
    {
        delegate void print(int a, int b);
        static void Main(string[] args)
        {
           print  swapdel = PrintNumber;
            swapdel(10, 20);
            Console.ReadKey();
        }
        public static void PrintNumber(int x, int y)
        {

            int z;
            z = x;
            x = y;
            y = z;
            Console.WriteLine("a=" + x + " " + "b=" + y);

        }

    }
}
