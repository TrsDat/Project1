namespace Project1
{
    public class buoi2
    {
        public static void ex1()
        {
            // bai celsius
            Console.Write("celsius = ");
            double celsius = Convert.ToSingle(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenhelt = celsius * 18 / 10 + 32;
            Console.WriteLine($"kelvin = {kelvin}");
            Console.WriteLine($"fahrenhelt = {fahrenhelt}");
        }
        public static void ex2()
        {
            Console.Write("ban kinh = ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"surface = {surface:f2}");
            Console.WriteLine($"volume = {volume:f2}");
        }
        public static void ex3()
        {
            double a= double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());
            Console.WriteLine($"12 + 3 = {12+3}");
            Console.WriteLine($"12 - 3 = {12-3}");
            Console.WriteLine($"12 * 3 = {12*3}");
            Console.WriteLine($"12 / 3 = {12/3}");
            Console.WriteLine($"12 mod 3 = {12%3}");
        }
    }
}