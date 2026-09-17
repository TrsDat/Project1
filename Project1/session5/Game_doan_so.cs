////Máy tính nghĩ ra ngẫu nhiên 1 số từ 1 đến 100, cho người dùng đoán. Game có 3 levels dễ/trung bình/khó tương ứng với được gieo 9/6/4 lần gieo.
////nếu mức dễ thì tiền cược được 1/2 lần tiền đặt, trung bình thì được 1 lần đặt, khó thì thắng 3 lần đặt.
////Trò chơi sẽ kết thúc khi người chơi chọn không chơi nữa hoặc số tiền còn lại 0 đồng .
//namespace Project1.session5
//{
//    internal class Game_doan_so
//    {
//        public static void Main(String[] args) 
//        {
//            vaogame();
//        }
//        public static void vaogame()
//        {
//            double tien = 1_000_000;
//            int luot = 0;
//            string choitiep = "";
//            int cuoc = 0;
//            double boiso = 0;
//            Console.WriteLine($"Ban dang co {tien}VND");
//            do
//            {
//                do
//                {
//                    Console.WriteLine("Ban muon cuoc bao nhieu?");
//                    bool muoncuoc = int.TryParse(Console.ReadLine(), out int result);
//                    if (muoncuoc && result <= tien)
//                    {
//                        cuoc = result; break;
//                    }
//                    else Console.WriteLine("So tien khong hop le");
//                } while (true);
//                if (cuoc == 0) break;


//                do
//                {
//                    Console.WriteLine("Ban chon che do nao? De(D) Trung binh(TB) Kho(K)");
//                    string dokho = Console.ReadLine().ToLower();
//                    if (dokho == "d")
//                    {
//                        luot = 9; boiso = 0.5;
//                        Console.WriteLine($"Ban co {luot} luot chon");
//                        break;
//                    }
//                    else if (dokho == "tb")
//                    {
//                        luot = 6; boiso = 1;
//                        Console.WriteLine($"Ban co {luot} luot chon");
//                        break;
//                    }
//                    else if (dokho == "k")
//                    {
//                        luot = 4; boiso = 3;
//                        Console.WriteLine($"Ban co {luot} luot chon");
//                        break;
//                    }
//                    else Console.WriteLine("Do kho khong hop le.");
//                } while (true);
//                Console.WriteLine(boiso);
//                Random dice = new Random();
//                int kq = dice.Next(1, 101);
//                int traloi = 0;
//                int win = 0;
//                while (luot > 0)
//                {
//                    luot--;
//                    Console.Write("Cau tra loi cua ban la: ");
//                    traloi = int.Parse(Console.ReadLine());
//                    if (traloi == kq)
//                    {
//                        Console.WriteLine("Chinh xac!");
//                        tien += cuoc*boiso; win = 1;
//                        break;
//                    }
//                    else if (traloi > kq)
//                    {
//                        Console.WriteLine("Cau tra loi cua ban lon hon dap an");
//                        Console.WriteLine($"Ban con {luot} luot");
//                    }
//                    else if (traloi < kq)
//                    {
//                        Console.WriteLine("Cau tra loi cua ban nho hon dap an");
//                        Console.WriteLine($"Ban con {luot} luot");
//                    }
//                }
//                if (win == 0) tien -= cuoc; win = 0;

//                Console.WriteLine($"Dap an chinh xac la {kq}");
//                Console.WriteLine($"Ban con {tien}VND");
//                Console.WriteLine("Ban co muon choi tiep khong(C/K)");
//                choitiep = Console.ReadLine().ToLower();
//            } while (choitiep != "k" && tien>0);
//            Console.WriteLine("Cam on ban da tham gia!");
//        }
//    }
//}
