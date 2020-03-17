using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class MyGenericClass<G>
    {
       public G GenericVariable;
        public MyGenericClass(G value)
        {
            GenericVariable = value;
        }
        public G GenericMethod(G GenericParameter)
        {
            Console.WriteLine("Parameter Type:{0}, value:{1}", typeof(G).ToString(),GenericParameter);
            Console.WriteLine("return Type:{0}, value:{1}", typeof(G).ToString(), GenericVariable);

            return GenericVariable;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            MyGenericClass<int> InnerClass = new MyGenericClass<int>(10);
            int val = InnerClass.GenericMethod(200);
            MyGenericClass<string> stringClass = new GenericClass.MyGenericClass<string>("Blue Lotus Technologies");
            string ab = stringClass.GenericMethod("Hello");

            Console.ReadKey();
        }
    }
}
  