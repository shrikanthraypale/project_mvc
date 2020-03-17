using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Address
    {
        public string addressline, city, state;
        public Address(string addressline, string city, string state)
        {
            this.addressline=addressline;
            this.city = city;
            this.state = state;

        }
    
    }
    public class Employee
    {
        public string Name, Job;
        public Address address;
        public Employee(string Name, string Job, Address address)
        {
            this.Name = Name;
            this.Job = Job;
            this.address = address;
        }
        public void display()
        { 
           
            Console.WriteLine(Name + " " + Job + "" + address.addressline+" "+address.city+" "+address.state);

        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Sai Nagar","Rajura","Maharashtra");
            Employee e1 = new Employee("Shrikant","Emginner",a1);
            e1.display();
            Console.ReadKey();
        }
       
       
    }
   
   
}
