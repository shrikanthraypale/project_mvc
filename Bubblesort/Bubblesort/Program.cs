﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13};
            int temp;

            for (int j = 0; j < arr.Length - 2; j++)
                {
                 for (int i = 0; i < arr.Length - 2; i++)
                     {
                        if (arr[i] > arr[i + 1])
                        {
                           temp = arr[i + 1];
                           arr[i + 1] = arr[j];
                           arr[i] = temp;
                    }
                }

            }
            Console.WriteLine("Bubble sort array is:");
            foreach (int x in arr)
            Console.Write(x +"   ");  
            Console.ReadKey();

        }
    }
}
