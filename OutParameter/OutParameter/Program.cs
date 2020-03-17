using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class Parameter
    { 
        public int square(out int x)
        {
            Console.WriteLine("Enter the value for x:");
            x=Convert.ToInt32(Console.ReadLine());
            return (x*x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parameter d = new Parameter();
            int i, j;
            j=d.square(out i);
            Console.WriteLine("Result :{0}", j);
            Console.ReadKey();


        
        }
    }
}
