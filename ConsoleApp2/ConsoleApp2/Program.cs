using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class simple_program
    {
        int a;
        public int square()
        {
            return (a * a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
