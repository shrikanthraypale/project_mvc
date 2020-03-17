using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inherit
{
    interface IDemo
    {
        void display();
    }
    class Test : IDemo
    {
        public void display()
        {
            Console.WriteLine("Implementing Multiple Interface");

        }
    }
   
    class Test1 : IDemo
    {
        public void display()
        {
            Console.WriteLine("This is second interface");
        }
    }
   
    class Program
    {
        public static void Main(String[] args)
        {
            Test t = new Test();
            Test1 t1 = new Test1();
            t.display();
            t1.display();
            Console.ReadLine();
        }
    }
}

