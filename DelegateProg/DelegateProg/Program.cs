using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProg
{
    class Program
    {
        public delegate void print(int value); 
        static void Main(string[] args)
        {

            print printDel = printNumber;
            printDel(10000);
            printDel(200);
            printDel = printMoney;
            printDel(10000);
            printDel(200);
            Console.ReadKey();
        }
        public static void printNumber(int num)
        {
            Console.WriteLine("Number is:{0,-12:N0}", num);

        }
        public static void  printMoney(int money)
        {
            Console.WriteLine("Money:{0:C}", money);

        }
    }
}
