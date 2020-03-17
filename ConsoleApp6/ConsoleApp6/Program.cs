using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public int Add(int FN,int SN)
        {
            return FN + SN;
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            int Sum = p.Add(10, 20);
            Console.WriteLine("Sum={0}", Sum);

        }
         

    }
  
}
