using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class calculator
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
        public int sub(int a, int b)
        {
            return (a-b);
        }

    }
}

interface ITest
{
    string msg();
}
public class Greet : ITest
{
    public string msg()
    {
        string Name = "";
        return "Hello" + Name;
    }
}
