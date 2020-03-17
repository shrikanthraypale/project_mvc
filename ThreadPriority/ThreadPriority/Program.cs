using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Work);
            Thread t2 = new Thread(Work);
            Thread t3 = new Thread(Work);

            t1.Priority = System.Threading.ThreadPriority.Highest;
            t2.Priority = System.Threading.ThreadPriority.BelowNormal;
            t3.Priority = System.Threading.ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("First Thread Priority:{0}", t1.Priority);
            Console.WriteLine("Second Thread Priority:{0}", t2.Priority);
            Console.WriteLine( "Third Thread Priority:{0}", t3.Priority);

            Console.ReadKey();


        }
        public static void Work()
        {
            Thread.Sleep(1000);
        }
    }
}
