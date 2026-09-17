using System.Diagnostics.CodeAnalysis;

namespace Project1.session4
{
    internal class exbuoi5
    {
        public static void ex5()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();
            }

            number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int space = 1; space <= 4 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();
            }
        }
        public static void ex6()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            Console.Write("1");
            if (n!=1)
            for (int i = 2; i <= n; i++)
            {
                Console.Write($" + 1/{i}");
                sum += 1.0 / i;
            }
            Console.Write($" = {sum:f2}");
        }
        public static void ex7()
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i=begin; i<=end; i++)
            if (perfect(i)) Console.Write($"{i} ");
        }
        public static bool perfect(int n)
        {
            if (n < 6) return false;
            int sum = 1;
            for (int i=2;i*i<=n;i++)
            if (n%i==0)
            {
                    sum += i;
                    sum += n / i;
                    if (i == n / i) sum -= i;
                    
            }
            if (sum == n) return true;
            else return false;
        }
    }
}
