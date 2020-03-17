using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNumber();
        }
        public void EvenNumber()
        {
            int start = 0;
            while (start < 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            Console.ReadKey();
            
        }
    }
}
