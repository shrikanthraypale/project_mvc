using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread1
{
    class Program
    {
        public static void msg()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("My first Thread");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread ObjT = new Thread(msg);

            try
            {
                ObjT.Name = "Test";
                Console.WriteLine(ObjT.Name.ToString());
                ObjT.Start();
            }

            catch(Exception E)
            {
                Console.WriteLine(E.Message.ToString());
            }

            Console.ReadKey();
        }
    }
}
