using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInherit
{
    sealed class Demo
    {
        protected int a = 76, b = 10;
        public void display()
        {

            Console.WriteLine("This is first Multilevel program");
        }

    }
    class Sample // : Demo-due to sealed class i cant inherit the Demo class.
    {
        public void add()
        {

            Console.WriteLine("Results is:{0}", (a + b));
       }
    }
    class Test : Sample
    {
        public void square()
        {
            int a = 7;
            Console.WriteLine("Sqaure is :{0}", (a * a));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
           t.display();
            t.add();
            t.square();
            Console.ReadKey();
        }
    }
}

