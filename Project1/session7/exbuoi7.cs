using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.session7
{
    internal class exbuoi7
    {
        public static void ex8()
        {
            Console.Write("n = ");
            int n= int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            int[] p = new int[1000001];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            foreach (int i in arr)
                if (p[i] == 0)
                {
                    p[i]++;
                    Console.Write($"{i} ");
                }
        }
    }
}
