using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Project1.session6
{
    internal class baitapbuoi6
    {
        public static void ex1()
        {
            Console.Write("a = "); int a=int.Parse(Console.ReadLine());
            Console.Write("b = "); int b=int.Parse(Console.ReadLine());
            Console.WriteLine($"a + b = {TinhTong(a,b)}");
        }
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        public static void ex2()
        {
            Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n)) Console.WriteLine("La so chan");
            else Console.WriteLine("La so le");
        }
        public static bool KiemTraChan(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }

        public static void ex3()
        {
            Console.Write("a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("b = "); int b = int.Parse(Console.ReadLine());
            Console.Write("c = "); int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max = {TimMax(a,b,c)}");
        }
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        public static void ex4()
        {
            Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"n! = {TinhGiaiThua(n)}");
        }
        public static long TinhGiaiThua(int n)
        {
            long tich = 1;
            for (int i = 1; i <= n; i++) tich *= i;
            return tich;
        }

        public static void ex5()
        {
            string s = Console.ReadLine();
            Console.WriteLine(DaoNguocChuoi(s));
        }
        public static string DaoNguocChuoi(string input)
        {
            if (input == null) return null;
            char[] x = input.ToCharArray();
            Array.Reverse(x);
            return new string(x);      ;
        }

        public static void ex6()
        {
            Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine(KiemTraNguyenTo(n));
        }
        public static bool KiemTraNguyenTo(int n)
        {
            if (n<=1) return false;
            for (int i=2;i*i<=n;i++)
                if (n%i==0) return false;
            return true;
        }

        public static void ex7()
        {
            Console.Write("n = ");
            bool parsed = int.TryParse(Console.ReadLine(), out int n);
            if (!parsed || n<0)
            {
                Console.WriteLine("Phai la so nguyen duong ");
                return;
            }
            InFibonacci(n);
        }
        public static void InFibonacci(int n)
        {
            int[] array = new int[n+2];
            array[0] = 0;
            array[1] = 1;
            for (int i = 0; i < n; i++)
            {
                if (i>=2) array[i] = array[i - 1] + array[i - 2];
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void ex8()
        {
            string s = Console.ReadLine();
            Console.WriteLine(DemNguyenAm(s));
        }
        public static int DemNguyenAm(string s)
        {
            int dem = 0;
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
                if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'u' || array[i] == 'o')
                    dem++;
            return dem;
        }

        public static void ex9()
        {
            Console.Write("x = "); int x = int.Parse(Console.ReadLine());
            Console.Write("y = "); int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"x^y= {TinhLuyThua(x,y)}");
        }
        public static double TinhLuyThua(double x, int y)
        {
            double kq = 1;
            for (int i = 1; i <= y; i++)
                kq *= x;
            return kq;
        }

        public static void ex10()
        {
            // 1. Đọc cả dòng chuỗi
            // 2. Tách chuỗi theo dấu cách (loại bỏ khoảng trắng thừa)
            // 3. Chuyển đổi từng phần tử sang kiểu int
            // 4. Chuyển thành mảng số nguyên
            int[] arr = Console.ReadLine()
                           .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            Console.WriteLine(TinhTrungBinh(arr));
        }
        public static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            for (int i = 0; i < arr.Length; i++)
                tong += arr[i];
            return tong/arr.Length;
        }
    }
}
