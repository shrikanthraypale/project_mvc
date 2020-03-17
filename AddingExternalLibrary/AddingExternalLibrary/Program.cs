using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace AddingExternalLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            int i, j, k;
            Console.Write("Enter the value of i:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of j:");
            j = Convert.ToInt32(Console.ReadLine());
            k = c.add(i, j);
            Console.WriteLine("Addition is:{0}", k);
            Console.ReadKey();

        }
    }
}
