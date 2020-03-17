using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    class ByReference
    {
        public int square(ref int a)
        {
            return a = a * a;

        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            ByReference Reference = new ByReference();
            int x, results;

            Console.WriteLine("Enter a value for x:");
            x = Convert.ToInt32(Console.ReadLine());
            results = Reference.square(ref x);
            
        }
       
    }
    Console.ReadKey();
}
