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
    }
}
