using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx2
{
    class GenericClass
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass genC = new GenericClass();
            genC.show("This is called by passing any type of argument");
            genC.show(123);
            genC.show(23.34f);
            Console.ReadKey();
        }
    }
}
