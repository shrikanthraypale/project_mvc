using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleInheritance
{
    class Demo
    {
        protected int x=10;
    }
    class sample : Demo
    {
        public void Square()
        {
            Console.WriteLine("square of x :{0}", (x * x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s.Square();
            Console.ReadKey();

        }
    }
   
}