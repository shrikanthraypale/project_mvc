using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningMembersinClass
{
    class student
    {
        int studentID;
        string studentName;

       
         public int SID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }

        }
        public string sname
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public void printDetail()
        {
            Console.WriteLine("Student ID:{0}", SID);
            Console.WriteLine("Student Name:",sname);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student student = new DefiningMembersinClass.student();
            Console.Write("Enter student id:");
            student.SID = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter student name:");
            student.sname = Console.ReadLine();
            student.printDetail();
            Console.ReadKey();
        }
    }
}
