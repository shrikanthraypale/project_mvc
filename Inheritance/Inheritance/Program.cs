using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Add
        {
        public int x, y;
        public void Set1( int a)
        {
            this.x = a;
        }
        public void  Set2( int b) {

            this.y = b;

        }

    }
    public class Result : Add
    {
        public void Res()
        {
            int resu =  x + y;
            Console.WriteLine("The rsult is { 0}" + resu);

        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result P1 = new Result();
            P1.Set1(1);
            P1.Set2(1);
            P1.Res();

            Console.ReadKey();
        }
    }
}
