using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx1
{
    class GenericClass<T>
    {
        public GenericClass(T Msg)
        {
             Console.WriteLine(Msg);
        }
       
    }
    class Program

    {
    public static void Main(String[] args)
    {
            GenericClass<String> G1 = new GenericClass<String>( "This is Program of Generic Class" );
            GenericClass<int> G2 = new GenericClass<int>(10);
            GenericClass<float> G3 = new GenericClass<float>(123.45f);
            Console.ReadKey();
    }
        
        
    }
}
