/////< summary >
///// Gieo 2 con súc sắc rồi tính tổng giá trị 2 mặt
///// nếu lớn hơn 6 thì gọi là tài, nhỏ hơn 6 thì gọi là xỉu, bằng 6 thì gọi là đặc biệt
///// 
///// đầu tiên,máy sẽ gieo súc sắc, sau đó người chơi sẽ đặt cược tài hoặc xỉu, 
///// nếu kết quả của máy và người chơi trùng nhau thì người chơi thắng, ngược lại thì thua
///// trong trường hợp đoán đúng số 6 thì người chơi sẽ được thưởng 3 lần số tiền đặt cược
///// 
///// sau mỗi lần chơi, máy sẽ hỏi người chơi có muốn chơi tiếp không, 
///// nếu người chơi đồng ý thì quay lại gieo súc sắc, ngược lại thì kết thúc trò chơi.
///// Khi kết thúc trò chơi, máy sẽ thông báo tổng số tiền thắng hoặc thua của người chơi.
///// 
///// </summary>
//namespace Project1.session5
//{
//    internal class Game_tai_xiu
//    {
//        public static void Main(String[] args)
//        {
//            vaogame();
//        }
//        public static void vaogame()
//        {
//            int tien = 1000000;
//            int solanthang = 0;
//            int solanthua = 0;
//            int solandacbiet = 0;
//            int solanchoi = 0;
//            string rep = "";
//            do
//            {
//                solanchoi++;
//                Console.WriteLine($"Ban co {tien}VND, ban muon dat cuoc bao nhieu");
//                int cuoc = 0;
//                do
//                {
//                    bool ok = int.TryParse(Console.ReadLine(), out int kq);
//                    if (ok && kq >= 1000 && kq <= tien)
//                    {
//                        cuoc = kq; break;
//                    }
//                    else
//                    {
//                        Console.WriteLine($"So tien cuoc phai nho hon luong tien hien co la {tien} va khong nho hon 1000");
//                        Console.WriteLine("Ban cuoc bao nhieu");
//                    }
//                } while (true);

//                Random rand = new Random();
//                int dice1 = rand.Next(1, 7);
//                int dice2 = rand.Next(1, 7);
//                int sum = dice1 + dice2;

//                do
//                {
//                    Console.WriteLine("Ban chon Tai(T), Xiu(X), hay Luc(L)");
//                    string guess = Console.ReadLine().ToLower();

//                    if (guess != "t" && guess != "x" && guess != "l")
//                        Console.WriteLine("Vui long nhap T,X,L");
//                    else
//                    {
//                        Console.WriteLine($"Ket qua la {dice1} + {dice2} = {sum}");
//                        if ((guess == "t" && sum > 6) || (guess == "x" && sum < 6))
//                        {
//                            tien += cuoc;
//                            solanthang++;
//                            Console.WriteLine($"Ban thang ! So tien hien tai la {tien}");
//                            break;
//                        }
//                        else if (guess == "l" && sum == 6)
//                        {
//                            solandacbiet++;
//                            tien = tien + cuoc * 3;
//                            Console.WriteLine($"Ban thang giai dac biet ! So tien hien tai la {tien}");
//                            break;
//                        }
//                        else
//                        {
//                            solanthua++;
//                            tien -= cuoc;
//                            Console.WriteLine($"Ban thua ! So tien hien tai la {tien}");
//                            break;
//                        }
//                    }
//                } while (true);

//                Console.WriteLine("Ban co muon tiep tuc khong (C/K)");
//                rep = Console.ReadLine().ToLower();

//            } while (rep != "k");
//            Console.WriteLine($"So tien hien co la {tien}");
//            Console.WriteLine($"So lan choi la {solanchoi}");
//            Console.WriteLine($"So lan thang la {solanthang}");
//            Console.WriteLine($"So lan thua la {solanthua}");
//            Console.WriteLine($"So lan thang giai dac biet la {solandacbiet}");
//        }
//    }
//}
