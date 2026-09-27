using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project1.session7
{
    internal class exbuoi7
    {
        /*Create a random integer values array, then create functions that:
        1.to calculate the average value of array elements.
        2.to test if an array contains a specific value.
        3.to find the index of an array element.
        4.to remove a specific element from an array.
        5.to find the maximum and minimum value of an array.
        6.to reverse an array of integer values.
        7.to find duplicate values in an array of values.
        8.to remove duplicate elements from an array.*/
        public static void ex1()
        {
            Random rnd=new Random();
            int n=rnd.Next(10,101); 
            int[] arr = new int[n];
            //1.to calculate the average value of array elements.
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write($"{arr[i]}  ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine($"average = {sum/n}");
            //2.to test if an array contains a specific value.
            //3.to find the index of an array element.
                Console.WriteLine("the specific value to test");
            int test1=int.Parse(Console.ReadLine());
            int p = 0;
            for (int i=0;i<n;i++)
                if (arr[i]==test1) { p = 1; Console.Write($"{i}  "); }
            if (p == 0) Console.Write("Khong tim thay");
            Console.WriteLine();
            //4.to remove a specific element from an array.
            Console.WriteLine("the value want to remove");
            int test2 = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                if (arr[i] == test2)
                {
                    for (int j = i; j < n - 1; j++)
                        arr[j] = arr[j + 1];
                    n--;
                }
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
            //5.to find the maximum and minimum value of an array.
            //6.to reverse an array of integer values.
            int[] arr2 = new int[n];
            p = n-1;
            int max = arr[0], min = arr[0];
            for (int i=0;i<n;i++)
            {
                arr2[p] = arr[i];
                p--;
                max = Math.Max(max, arr[i]);
                min = Math.Min(min, arr[i]);
            }
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine("After remove duplicate");
            //7.to find duplicate values in an array of values.
            //8.to remove duplicate elements from an array.
            int[] arr3 = new int[101];
            for (int i = 0; i < n; i++)
            {
                arr3[arr2[i]]++;
                if (arr3[arr2[i]] > 1)
                {
                    for (int j = i; j < n - 1; j++)
                        arr2[j] = arr2[j + 1];
                    n--;
                }
                else Console.Write($"{arr2[i]}  ");
            }
        }
        /*Create a C# program that
        -requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        -Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.*/
        public static void ex2()
        {

        }
    }
}