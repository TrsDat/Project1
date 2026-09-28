using System;
using System.Collections.Generic;
using System.Drawing;
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
            Random rnd = new Random();
            int n = rnd.Next(10, 101);
            int[] arr = new int[n];
            //1.to calculate the average value of array elements.
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write($"{arr[i]}  ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine($"average = {sum / n}");
            //2.to test if an array contains a specific value.
            //3.to find the index of an array element.
            Console.WriteLine("the specific value to test");
            int test1 = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] == test1) { p = 1; Console.Write($"{i}  "); }
            if (p == 0) Console.Write("Khong tim thay");
            Console.WriteLine();
            //4.to remove a specific element from an array.
            Console.WriteLine("the value want to remove");
            int test2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
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
            p = n - 1;
            int max = arr[0], min = arr[0];
            for (int i = 0; i < n; i++)
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
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i=0;i<10;i++)
            {
                arr[i]= rnd.Next(0,101);
                Console.Write($"{arr[i]} ");
            }
            // bubble sort
            for (int i=0;i<9;i++)
                for (int j=0;j<9-i;j++)
                    if (arr[j] > arr[j+1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
            Console.WriteLine();
            foreach (int i in arr) Console.Write($"{i} ");
            Console.WriteLine();
            //

            Console.Write("Sentence : ");
            string sentence = Console.ReadLine();
            Console.Write("Target word : ");
            string target= Console.ReadLine();
            int p, p2 = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == target[0])
                {
                    p = 0;
                    for (int j = i; j < sentence.Length; j++)
                    {
                        if (sentence[j] != target[p]) break;
                        else p++;
                        if (p==target.Length) break;
                    }
                    if (p == target.Length)
                    {
                        Console.WriteLine($"Found target begin at {i + 1}");
                        p2 = 1;
                    }                    
                }
            }
            if (p2 == 0) Console.WriteLine("Khong tim thay");
        }
        /*
        Create a program with following functions
        -Create an integer matrix N x M (N,M was prompted from user) randomly.
        -Print the matrix.
        -Print the ith row/column. (i was prompted from user)
        -Find the max value of the matrix.
        -Find the min value of ith row/col of the matrix.
        -Transpose the matrix.
        -Print the main/secondary diagonal values of the matrix.(square maxtrix)*/
        public static void ex3()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Random rnd = new Random();

            //-Create an integer matrix N x M (N,M was prompted from user) randomly.
            //-Print the matrix.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 101);
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }

            //-Print the ith row / column. (i was prompted from user)
            Console.Write("Row i = ");
            int row = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++) Console.Write($"{arr[row-1,j]}\t");
            Console.WriteLine();
            Console.Write("Column i = ");
            int column = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < column; j++) Console.Write("\t");
                Console.WriteLine($"{arr[i, column - 1]}\t");
            }

            //-Find the max value of the matrix.
            int max = arr[0, 0];
            foreach (int i in arr) max = Math.Max(max, i);
            Console.WriteLine($"Max of matrix : {max}");

            //-Find the min value of ith row/col of the matrix.
            int min;
            Console.Write("Find min in row : ");
            row = int.Parse(Console.ReadLine());
            min = arr[row - 1, 0];
            for (int j = 0; j < m; j++) min = Math.Min(arr[row - 1, j], min);
            Console.WriteLine($"Min of row {row} is {min}");

            Console.Write("Find min in column : ");
            column = int.Parse(Console.ReadLine());
            min = arr[0,column - 1];
            for (int i = 0; i < n; i++) min = Math.Min(arr[i,column-1], min);
            Console.WriteLine($"Min of column {column} is {min}");

            //-Transpose the matrix.
            Console.WriteLine("Transpose the matrix");
            int[,] arr2 = new int[m, n];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    arr2[j, i] = arr[i, j];
                    Console.Write($"{arr2[j,i]}\t");
                }
                Console.WriteLine();
            }

            //-Print the main/secondary diagonal values of the matrix.(square maxtrix)
            if (n==m)
            {
                Console.WriteLine("Main diagonal values");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++) Console.Write("\t");
                    Console.WriteLine(arr2[i, i]);
                }

                Console.WriteLine("Secondary diagonal values");
                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++) Console.Write("\t");
                    Console.WriteLine(arr2[n - i - 1, i]);
                }
            }
            
        }
    }
}