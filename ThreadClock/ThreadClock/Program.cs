using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to Clock");
            Console.SetCursorPosition(03, 08);
            Console.Write("12 hours clock in");
            Console.SetCursorPosition(20, 08);
            Console.WriteLine("hr:min:sec:msec");
            //Console.Beep();

            for (int hr = 0; hr <= 11; hr++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        for (int msec = 0; msec <= 99; msec++)
                        {
                            if (hr < 10)
                            {
                                if (min < 10)
                                {
                                    if (sec < 10)
                                    {
                                        Console.SetCursorPosition(20, 10);
                                        Console.Write("0{0}:0{1}:0{1}:0{2}", hr, min, sec, msec);
                                        Thread.Sleep(10);
                                    }
                                    else if (min >= 10)
                                    {
                                        if (sec < 10)
                                        {
                                            Console.SetCursorPosition(20, 10);
                                            Console.Write("0{0}:0{1}:0{1}:0{2}", hr, min, sec, msec);
                                            Thread.Sleep(10);
                                        }
                                    }
                                    else if (sec >= 10)
                                    {
                                        if (msec < 10)
                                        {
                                            Console.SetCursorPosition(20, 10);
                                            Console.Write("0{0}:0{1}:0{1}:0{2}", hr, min, sec, msec);
                                            Thread.Sleep(10);
                                        }
                                    }
                                    else if (msec >= 10)
                                    {
                                        Console.SetCursorPosition(20, 10);
                                        Console.Write("0{0}:0{1}:0{1}:0{2}", hr, min, sec, msec);
                                        Thread.Sleep(10);
                                    }
                                }
                            }
                        }
                        //Console.Beep();
                    }
                    //Console.Beep();Console.Beep();
                }
            }
            Console.ReadKey();
        }
    }
}
