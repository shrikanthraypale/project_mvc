using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class calculate
    {
        public int add(int a, int b)
        {
            return(a+b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            calculate calc = new calculate();
            Console.Write("enter i:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter j:");
            j = Convert.ToInt32(Console.ReadLine());
            k = calc.add(i, j);
            Console.WriteLine("Result:{0}", k);
            Console.ReadKey();
        }
    }
}
