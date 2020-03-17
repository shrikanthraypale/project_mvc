using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenes
{
    class Employee
    {
        private string Empname = " ";
        private int salary = 0;
        private string Department = " ";
        public string Name
        {
            get
            {
                return Empname;
            }
            set
            {
                Empname = value;
            }

        }
        public int sal
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public string dept
        {
            get
            {
                return Department;
            }
            set
            {
                Department = value;
            }
        }
        public override string ToString()
        {
            return "Name=" + Name + ",sal=" + sal + ",dept=" + dept;
        }


        static void Main(string[] args)
        {
            Employee E = new Employee();
            Console.WriteLine("Detail of Employee {0}", E);
            E.Empname = "Rahul";
            Console.WriteLine("Detail of Employee {0}", E);
            E.salary = 30000;
            Console.WriteLine("Detail of Employee {0}", E);
            E.Department = "Traineer";
            Console.WriteLine("Detail of Employee {0}", E);
            Console.ReadKey();


        }
    }
}
