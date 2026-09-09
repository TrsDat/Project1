namespace Project1
{
    public class buoi3
    {
        public static void ex1()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
        public static void ex2()
        {
            double y = Convert.ToDouble(Console.ReadLine());
            double x = Math.Pow(y, 2) + 2 * y + 1;
            Console.WriteLine(x);
        }
        public static void ex3()
        {
            Console.Write("distance(km): ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("time(hours): ");
            double t = Convert.ToDouble(Console.ReadLine());
            double v = s / t;
            Console.WriteLine($"speed (km/h) : {v:f2}");
            Console.WriteLine($"speed (miles/h) : {v / 0.621371:f2}");

        }
        public static void ex4()
        {
            Console.Write("ban kinh = ");
            double r = Convert.ToDouble(Console.ReadLine());
            double dientichbemat = 4 * Math.PI * Math.Pow(r, 2);
            double thetich = 4 / 3.0 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"dien tich be mat : {dientichbemat:f2}");
            Console.WriteLine($"the tich : {thetich:f2}");

        }
        public static void ex5()
        {
            char a = Convert.ToChar(Console.ReadLine());
            int ascii = (int)a;
            if (a == 'a' || a == 'e' || a == 'u' || a == 'o' || a == 'i')
                Console.WriteLine("la nguyen am");
            else if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90))
                Console.WriteLine("la phu am");
            else if (ascii >= 48 && ascii <= 57)
                Console.WriteLine("la so");
            else Console.WriteLine("khac");
        }
    }
}
