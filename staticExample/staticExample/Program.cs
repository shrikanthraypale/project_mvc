using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticExample
{
    static class Test
    {
        public static int i;
        public static void Msg()
        {
            Console.WriteLine("This is static method");
        
            
        }
        public static int square(int a)
        {
            return (a * a);
        }

        
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.Msg();
            int input;
            Test.i = 100;
            Console.WriteLine("square of this is:{0}", (Test.i * Test.i));
            Console.Write("Enter a value for:");
            input = Convert.ToInt32(Console.ReadLine());
            int output = Test.square(input);
            Console.WriteLine("squaresssss of give number is :{0}", output);
             Console.ReadLine();


        }
    }
}
