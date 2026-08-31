using static System.Runtime.InteropServices.JavaScript.JSType;

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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"12 + 3 = {12 + 3}");
            Console.WriteLine($"12 - 3 = {12 - 3}");
            Console.WriteLine($"12 * 3 = {12 * 3}");
            Console.WriteLine($"12 / 3 = {12 / 3}");
            Console.WriteLine($"12 mod 3 = {12 % 3}");
        }
        public static void bai1()
        {
            double diencu = Convert.ToSingle(Console.ReadLine());
            double dienmoi = Convert.ToSingle(Console.ReadLine());
            double luongdien = dienmoi - diencu;
            double tienchuatheothue = 0;
            Console.WriteLine($"so dien tieu thu = {luongdien}");
            if (luongdien > 0)
            {
                if (luongdien <= 50)
                {
                    tienchuatheothue = luongdien * 1.806;
                }
                else if (luongdien <= 100)
                {
                    tienchuatheothue = 50 * 1.806 + (luongdien - 50) * 1.866;
                }
                else if (luongdien <= 200)
                {
                    tienchuatheothue = 50 * 1.806 + 50 * 1.866 + (luongdien - 100) * 2.167;
                }
                else if (luongdien <= 300)
                {
                    tienchuatheothue = 50 * 1.806 + 50 * 1.866 + 100 * 2.167 + (luongdien - 200) * 2.729;
                }
                else
                {
                    tienchuatheothue = 50 * 1.806 + 50 * 1.866 + 100 * 2.167 + 100 * 2.729 + (luongdien - 300) * 3.050;
                }
                double tienthuevat = tienchuatheothue * 0.08;
                double tongtienphaitra = tienchuatheothue + tienthuevat;
                Console.WriteLine($"tien dien chua thue = {tienchuatheothue:F2}");
                Console.WriteLine($"thue vat = {tienthuevat:F2}");
                Console.WriteLine($"tong thanh toan = {tongtienphaitra:F2}");

            }
            else
            {
                Console.WriteLine("chi so moi phai lon hon chi so cu");
            }
        }
        public static void bai2()
        {
            Console.Write("chieu cao (m) = ");
            double chieucao = Convert.ToSingle(Console.ReadLine());
            Console.Write("can nang (kg) = ");
            double cannang = Convert.ToSingle(Console.ReadLine());
            double bmi = cannang / Math.Pow(chieucao, 2);
            Console.WriteLine($"chi so BMI = {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("phan loai suc khoe: gay");
            }
            else if (bmi < 23 && bmi >= 18.5)
            {
                Console.WriteLine("phan loai suc khoe: binh thuong");
            }
            else if (bmi < 25 && bmi >= 23)
            {
                Console.WriteLine("phan loai suc khoe: thua can");
            }
            else
            {
                Console.WriteLine("phan loai suc khoe: beo phi");
            }
            double cannangtoithieu = 18.5 * Math.Pow(chieucao, 2);
            double cannangtoida = 22.9 * Math.Pow(chieucao, 2);
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {cannangtoithieu:f2} kg đến {cannangtoida:f2} kg");
        }
        public static void bai3()
        { 
            Console.Write("nhap so tien VND = ");
            decimal sotienvnd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int chon = Convert.ToInt32(Console.ReadLine());
            decimal phidichvu = sotienvnd * 0.005m;
            decimal sotienvndthucte = sotienvnd - phidichvu;
            decimal sotienngoai = 0;
            string kyhieu = "";
            switch (chon)
            {
                case 1:
                    sotienngoai = sotienvndthucte / 25400;
                    kyhieu = "USD";
                    break;
                case 2:
                    sotienngoai = sotienvndthucte / 27200;
                    kyhieu = "EUR";
                    break;
                case 3:
                    sotienngoai = sotienvndthucte / 165;
                    kyhieu = "JPY";
                    break;
                case 4:
                    sotienngoai = sotienvndthucte / 32100;
                    kyhieu = "GBP";
                    break;
                default:
                    Console.WriteLine("chon ngoai te khong hop le");
                    break;
            }
            Console.WriteLine($"phi dich vu (0.5%) : {phidichvu:N0} VND");
            Console.WriteLine($"so tien VND tinh doi: {sotienvndthucte:N0} VND");
            Console.WriteLine($"so {kyhieu} nhan duoc {sotienngoai:F2} ");
        }
        public static void bai5()
        {
            Console.Write("nhap diem C# (4 TC): "); double diemC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine() ; Console.Write("nhap diem Toan (3 TC): "); double diemT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(); Console.Write("nhap diem Tieng Anh (2 TC): "); double diemTA = Convert.ToDouble(Console.ReadLine());
            double diemTB = (diemC * 4 + diemT * 3 + diemTA * 2) / (4 + 3 + 2);
            if (diemTB >= 8.5)
            {
                Console.WriteLine($"Diem TB Thang 10: {diemTB:F2}");
                Console.WriteLine($"Diem Chu Quy Doi: A");
                Console.WriteLine($"Diem GPA Thang 4: 4.0");
                Console.WriteLine($"Xep Loai Hoc Luc: Xuat sac / Gioi");
            }
            else if (diemTB >= 7.0)
            {
                Console.WriteLine($"Diem TB Thang 10: {diemTB:F2}");
                Console.WriteLine($"Diem Chu Quy Doi: B");
                Console.WriteLine($"Diem GPA Thang 4: 3.0");
                Console.WriteLine($"Xep Loai Hoc Luc: Kha");
            }
            else if (diemTB >= 5.5)
            {
                Console.WriteLine($"Diem TB Thang 10: {diemTB:F2}");
                Console.WriteLine($"Diem Chu Quy Doi: C");
                Console.WriteLine($"Diem GPA Thang 4: 2.0");
                Console.WriteLine($"Xep Loai Hoc Luc: Trung binh");
            }
            else if (diemTB >= 4.0)
            {
                Console.WriteLine($"Diem TB Thang 10: {diemTB:F2}");
                Console.WriteLine($"Diem Chu Quy Doi: D");
                Console.WriteLine($"Diem GPA Thang 4: 1.0");
                Console.WriteLine($"Xep Loai Hoc Luc: Yeu");
            }
            else
            {
                Console.WriteLine($"Diem TB Thang 10: {diemTB:F2}");
                Console.WriteLine($"Diem Chu Quy Doi: F");
                Console.WriteLine($"Diem GPA Thang 4: 0.0");
                Console.WriteLine($"Xep Loai Hoc Luc: Kem (Truot)");
            }
        }
    }
}