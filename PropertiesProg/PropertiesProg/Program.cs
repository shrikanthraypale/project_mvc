using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProg
{
    class Program
    {
        public class Employee
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;

                }
                set
                {
                    name=value;
                }
            }
                
            
            
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Shrikant Raypale";
            Console.WriteLine("What is your name:" + e.Name);
            Console.ReadKey();
        }
    }
}
