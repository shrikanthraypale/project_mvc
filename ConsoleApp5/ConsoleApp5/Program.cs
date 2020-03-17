using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0]=101;
            arr[1] = 102;
            arr[2] = 103;
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                    continue;
            }
            Console.ReadKey();
        }
    }
}
