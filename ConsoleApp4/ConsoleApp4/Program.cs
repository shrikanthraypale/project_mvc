using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your target");
            int target = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
               
            }
            Console.ReadKey();
            String UserChoice = "";
            do
            {
                Console.WriteLine("Do you want to Continue Yes or No ?");
                UserChoice = Console.ReadLine();
                if (UserChoice != "Yes" && UserChoice != "No")
                {
                    Console.WriteLine("Invalid choice,please say Yes or No");
                }
            } while (UserChoice != "Yes" && UserChoice != "No");
          
        }

    }
}
