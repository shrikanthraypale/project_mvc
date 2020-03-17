using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshap_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int numbers = int.Parse(Console.ReadLine());
            switch (numbers)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                case 30:
                    Console.WriteLine("number is 30");
                    break;
                default:
                    Console.WriteLine("This is invalid number");
                    break;
            }

            
            Console.ReadKey();

        }
    }
}
