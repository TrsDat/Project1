using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.session3
{
    internal class baitapbuoi3
    {
        public static void ex1()
        {
            Console.Write("Tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Gio chieu: ");
            double giochieu = double.Parse(Console.ReadLine());
            if (tuoi > 60 || tuoi < 12)
                Console.WriteLine("Gia ve la: 50,000 VND");
            else if (giochieu < 17)
                Console.WriteLine("Gia ve la: 80,000 VND");
            else Console.WriteLine("Gia ve la: 110,000 VND");
        }
        public static void ex2()
        {
            Console.Write("Role = ");
            string role = Console.ReadLine();
            if (role == "ADMIN") Console.WriteLine("Toan quyen quan tri he thong");
            else if (role == "MANAGER") Console.WriteLine("Quyen quan ly nhan su va xem bao cao");
            else if (role == "EMPLOYEE") Console.WriteLine("Quyen tao vaf chinh sua ho so ca nhan");
            else if (role == "GUEST") Console.WriteLine("Chi co quyen xem thong tin cong khai");
            else Console.WriteLine("Ma vai tro khong hop le");

        }

    }
}
