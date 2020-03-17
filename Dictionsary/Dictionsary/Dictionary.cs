using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionsary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> MyDic = new Dictionary <int,int>();
            int i;
            for (i = 1; i<= 25; i++) 
            {
                MyDic.Add(i, i);
            }
            foreach(var result in MyDic)  
            {
                Console.WriteLine(result.ToString());
            }
            Console.WriteLine("Element of mydic[3] is {0}", MyDic[3]);
            Console.WriteLine("No of element is" + MyDic.Count);
            MyDic.Remove(5);

            Console.WriteLine("After Removing and item from dictionary ");
            
            // Using arraylist collection class
             ArrayList MyList = new ArrayList();
            for(i = 1; i <= 10; i++)
            {
                MyList.Add(i.ToString());

            }
            Console.WriteLine("No of item in mylist:" + MyList.Count);
            foreach (var lst in MyList)
            {
                Console.WriteLine(lst.ToString());
            }
            Console.ReadKey();
        }
    }
}
