using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static void ex3()
        {
            Console.Write("So du = "); 
            long sodu = long.Parse(Console.ReadLine());
            Console.Write("So tien rut = ");
            long sotienrut= long.Parse(Console.ReadLine());
            if (sodu < 0) Console.WriteLine("So tien khong hop le");
            else if (sotienrut%50000!=0) Console.WriteLine("So tien rut phai la boi so của 50,000 VND");
            else if (sotienrut > sodu) Console.WriteLine("So tien rut vuot qua so du");
            else if (sotienrut > 5000000) Console.WriteLine("So tien rut vuot qua han muc");
            else Console.WriteLine($"Rut tien thanh cong. So du con lai: {sodu - sotienrut}");
        }
        public static void ex4()
        {
            int i = 0;
            do
            {
                Console.Write("Phim bam = ");
                int phimbam = int.Parse(Console.ReadLine());
                switch (phimbam)
                {
                    case 0: Console.WriteLine("Quay lai menu chinh"); break;
                    case 1: Console.WriteLine("Gap tong dai vien tu van the"); break;
                    case 2: Console.WriteLine("Tra cuu so du tai khoan"); break;
                    case 3: Console.WriteLine("Bao khoa the khanr cap"); break;
                    case 4: Console.WriteLine("Tra cuu ty gia ngoai te"); break;
                    default: Console.WriteLine("Lua chon khong hop le. Vui long thu lai"); i = 1; break;
                }
            } while (i != 0);            
        }
        public static void ex5()
        {
            double tong = 0;
            Console.Write("So km = ");
            double km = double.Parse(Console.ReadLine());
            if (km <= 1) tong = 15_000;
            else if (km <= 10) tong = 15_000 + (km - 1) * 12_000;
            else tong = 15_000 + 9 * 12_000 + (km - 10) * 10_000;
            if (km>30)
            {
                Console.WriteLine($"Tong tien truoc giam: {tong}");
                Console.WriteLine($"Khuyen mai (10%): -{tong * 0.1}");
                Console.WriteLine($"Thanh tien: {tong * 0.9}");
            }
            else Console.WriteLine($"Thanh tien: {tong}");
        }        
        public static void ex6()
        {
            Console.Write("Trang thai = ");
            int trangthai = int.Parse(Console.ReadLine());
            switch (trangthai)
            {
                case 1: Console.WriteLine("[Trang thai]: Cho xac nhan thanh toan"); break;
                case 2: Console.WriteLine("[Trang thai]: Dang dong goi va ban giao don vi van chuyen"); break;
                case 3: Console.WriteLine("[Trang thai]: Don hang dang tren duong giao den ban"); break;
                case 4: Console.WriteLine("[Trang thai]: Don hang da hoan thanh. Cam on ban!"); break;
                case 5: Console.WriteLine("[Trang thai]: Don hang da huy. Xuat phieu hoan tien."); break;
                default: break;
            }
        }
        public static void ex7()
        {
            Console.Write("Can nang (kg) = ");
            double cannang = double.Parse(Console.ReadLine());
            Console.Write("Chieu cao (m) = ");
            double chieucao = double.Parse(Console.ReadLine());
            double bmi = cannang / Math.Pow(chieucao,2);
            Console.WriteLine($"(BMI: {bmi:F2})");
            if (bmi < 18.5) Console.WriteLine("Thay gay - Nen bo sung dinh duong");
            else if (bmi < 25) Console.WriteLine("Can doi - Tiep tuc duy tri");
            else if (bmi < 30) Console.WriteLine("Thua can - Nen tang cuong luyen tap");
            else Console.WriteLine("Beo phi - Can su tu van tu bac si");
        }
        public static void ex8()
        {
            Console.Write("Loai xe : ");
            string loaixe = Console.ReadLine();
            Console.WriteLine("Thoi gian : ");
            int thoigian = int.Parse(Console.ReadLine());
            switch (loaixe)
            {
                case "BIKE":
                    {
                        if (thoigian == 1) Console.WriteLine("Phi gui xe dap (ban ngay): 5,000VND");
                        else if (thoigian == 2) Console.WriteLine("Phi gui xe dap (ban dem): 10,000VND");
                        else Console.WriteLine("Thoi gian khong hop le");
                    }
                    break;
                case "CAR":
                    {
                        if (thoigian == 1) Console.WriteLine("Phi gui xe o to (ban ngay): 30,000VND");
                        else if (thoigian == 2) Console.WriteLine("Phi gui xe o to (ban dem): 60,000VND");
                        else Console.WriteLine("Thoi gian khong hop le");
                    }
                    break;
                default: Console.WriteLine("Loai xe khong hop le"); break;
            }
        }
        public static void ex9()
        {
            Console.Write("GPA = ");
            double GPA = double.Parse(Console.ReadLine());
            Console.Write("DRL = ");
            int DRL = int.Parse(Console.ReadLine());
            if (GPA>=3.6 && DRL >=90) Console.WriteLine("Ket qua: Hoc bong Xuat sac (Muc 100%)");
            else if (GPA>=3.2 && DRL>=80) Console.WriteLine("Ket qua: Hoc bong Kha/Gioi (Muc 50%)");
        }
        public static void ex10()
        {
            Console.Write("nhap so tien VND = ");
            double sotienvnd = double.Parse(Console.ReadLine());
            Console.Write("Ma ngoai te : ");
            string ngoaite = Console.ReadLine();
            double quydoi = 0;
            switch (ngoaite)
            {
                case "USD": quydoi = sotienvnd / 25400; break;
                case "EUR": quydoi = sotienvnd / 27200; break;
                case "JPY": quydoi = sotienvnd / 165; break;
                default: Console.WriteLine("Ma ngoai te khong hop le"); break;
            }
            Console.WriteLine($"So tien sau quy doi : {quydoi:f2} {ngoaite}");
        }
    }
}
