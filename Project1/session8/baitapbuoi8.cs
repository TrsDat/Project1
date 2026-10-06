using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.session8
{
    internal class baitapbuoi8
    {
        public static void ex1()
        {
            int[][] arr = new int[4][];
            arr[0]=new int[] {1,1,1,1};
            arr[1]=new int[] {2,2};
            arr[2]=new int[] {3,3,3,3};
            arr[3]=new int[] {4,4};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length;j++)
                    Console.Write($"{arr[i][j]} ");
                Console.WriteLine();
            }
        }
        public static void ex2()
        {
            Random rnd = new Random();
            int n = rnd.Next(5, 11);
            int[][] arr = new int[n][];
            int[] maxrow = new int[n];
            for (int i = 0; i < n; i++)
            {
                int m=rnd.Next(1, 11);
                arr[i] = new int[m];
                for (int j=0;j<m;j++)
                {
                    arr[i][j] = rnd.Next(0,101);
                    Console.Write($"{arr[i][j]} ");
                    if (j == 0) maxrow[i] = arr[i][j];
                    else maxrow[i] = Math.Max(maxrow[i], arr[i][j]);
                }
                Console.WriteLine($"| max row {i+1} = {maxrow[i]}");
            }
            
            int max = maxrow[0];
            foreach (int i in maxrow) max = Math.Max(i, max);
            Console.WriteLine($"Max of array is {max}");
            Console.WriteLine("Sau khi sap xep");
            for (int i = 0; i < n; i++)
            {
                bubblesort(arr[i]);
                foreach (int j in arr[i]) Console.Write($"{j} ");
                Console.WriteLine();
            }
            Console.WriteLine("Cac so nguyen to");
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                    if (nguyento(j)) Console.Write($"{j} ");
                Console.WriteLine();
            }
            Console.Write("So muon tim :");
            int x = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i=0;i<arr.Length;i++)
                for (int j = 0; j < arr[i].Length;j++)
                    if (arr[i][j]==x)
                    {
                        p = 1;
                        Console.WriteLine(i+" "+j);
                    }
            if (p==0) Console.WriteLine("Khong tim thay");

        }
        public static void bubblesort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j=0;j<arr.Length-i-1;j++)
                    if (arr[j] > arr[j+1])
                    {
                        int t = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = t;
                    }
            }
        }
        public static bool nguyento(int x)
        {
            if (x % 2 == 0 || x % 3 == 0 || x % 5 == 0 || x < 2) return false;
            for (int i = 2; i * i < x; i++)
                if (x % i == 0) return false;
            return true;
        }
    }
}
