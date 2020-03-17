using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{

    class Program
    {
        private int x, y, z;
        public Program()
        {
            Console.WriteLine("Its is default constructor");
        }
        public Program(float domestic, float comerical)
        {
            Console.WriteLine((domestic + comerical));
            // total = domestic + comerical;
        }
        public Program(int y, int z, int i)
        {
            this.x = y;
            this.y = z;
            this.z = i;
            Console.WriteLine(y + z + i);
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            Program P1 = new Program(45,63);
            Program P2 = new Program(10, 20, 30);
            double units, domestic, comerical;
            Console.WriteLine("Enter user unit:");
            units = Convert.ToDouble(Console.ReadLine());
            if (units >= 0 && units <= 500) 
            {
                domestic = units * 0.75;
                comerical = units * ((0.75 * 20) / 100);
                Console.WriteLine("Eneter the domestic consumer : " + domestic);
                Console.WriteLine("Eneter the Comerical consumer : " + comerical);
                Console.ReadKey();
            }
            
            else if (units >= 501 && units <= 1000) 
            {
                domestic = units * 2.35;
                comerical = units * ((2.35 * 20) / 100);
                Console.WriteLine("Eneter the domestic consumer : " + domestic);
                Console.WriteLine("Eneter the Comerical consumer : " + comerical);
                Console.ReadKey();
            }

            else if (units >= 1001 && units <= 1500) 
            {
                domestic = units * 3.05;
                comerical = units * ((3.05 * 20) / 100);
                Console.WriteLine("Eneter the domestic consumer : " + domestic);
                Console.WriteLine("Eneter the Comerical consumer : " + comerical);
                Console.ReadKey();
            }
            else if (units >= 1501 && units <= 2000) 
            {
                domestic = units * 4.00;
                comerical = units * ((4.00 * 20) / 100);
                Console.WriteLine("Eneter the domestic consumer : " + domestic);
                Console.WriteLine("Eneter the Comerical consumer : " + comerical);
                Console.ReadKey();
            }
             else if (units >= 2001)
            {
                domestic = units * 5.15;
                comerical = units * ((5.15 * 20) / 100);
                Console.WriteLine("Eneter the domestic consumer : " + domestic);
                Console.WriteLine("Eneter the Comerical consumer : " + comerical);
                Console.ReadKey();
            }

        }


    }
}
