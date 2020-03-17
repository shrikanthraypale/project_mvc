using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProg2
{
    class Program
    {
        public class Employee
        {
            public string name;
                public string Name
                {
                    get
                    {
                    return name;
                    }
                    set
                    {
                        name = value+ "Rayple";
                    }
                    
                }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name="shrikant";
            Console.WriteLine("My Name is: "  +e.Name);
            Console.ReadKey();
        }
    }
}
