using System;
using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Config Console Output được Tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;
//            //1. Khai báo biến
//            int x1, x2, y1, y2;
//            //2. Nhập giá trị
//            Console.WriteLine("Nhập điểm A(x1, y1):");
//            Console.Write("- x1: ");
//            x1 = int.Parse(Console.ReadLine());
//            Console.Write("- y1: ");
//            y1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhập điểm B(x2, y2):");
//            Console.Write("- x2: ");
//            x2 = int.Parse(Console.ReadLine());
//            Console.Write("- y2: ");
//            y2 = int.Parse(Console.ReadLine());
//            //3. Tính khoảng cách
//            double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//            //4. Hiển thị kết quả
//            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) + {khoangCach}");
//        }
//    }
//}
//Bai1
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // 1. Nhập tên và tuổi
//            Console.Write("Nhập tên của bạn: ");
//            string ten = Console.ReadLine();

//            Console.Write("Nhập tuổi của bạn: ");
//            int tuoi = int.Parse(Console.ReadLine());

//            // 2. Hiển thị lời chào
//            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
//        }
//    }
//}
//bai2
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập chiều dài và chiều rộng
//            Console.Write("Nhập chiều dài: ");
//            double chieuDai = double.Parse(Console.ReadLine());

//            Console.Write("Nhập chiều rộng: ");
//            double chieuRong = double.Parse(Console.ReadLine());

//            // Tính diện tích
//            double dienTich = chieuDai * chieuRong;

//            // Hiển thị kết quả
//            Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
//        }
//    }
//}
//bài3
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập số nguyên
//            Console.Write("Nhập một số nguyên: ");
//            int soNguyen = int.Parse(Console.ReadLine());

//            // Kiểm tra chẵn hay lẻ
//            if (soNguyen % 2 == 0)
//            {
//                Console.WriteLine($"{soNguyen} là số chẵn.");
//            }
//            else
//            {
//                Console.WriteLine($"{soNguyen} là số lẻ.");
//            }
//        }
//    }
//}
//Bai5
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập hai số
//            Console.Write("Nhập số thứ nhất: ");
//            double a = double.Parse(Console.ReadLine());

//            Console.Write("Nhập số thứ hai: ");
//            double b = double.Parse(Console.ReadLine());

//            // Tính tổng và tích
//            double tong = a + b;
//            double tich = a * b;

//            // Hiển thị kết quả
//            Console.WriteLine($"Tổng của {a} và {b} là: {tong}");
//            Console.WriteLine($"Tích của {a} và {b} là: {tich}");
//        }
//    }
//}
//bai6
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập một số
//            Console.Write("Nhập một số bất kỳ: ");
//            double so = double.Parse(Console.ReadLine());

//            // Kiểm tra số dương, âm hay không
//            if (so > 0)
//            {
//                Console.WriteLine($"{so} là số dương.");
//            }
//            else if (so < 0)
//            {
//                Console.WriteLine($"{so} là số âm.");
//            }
//            else
//            {
//                Console.WriteLine("Đây là số không.");
//            }
//        }
//    }
//}
//bai7
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập năm
//            Console.Write("Nhập một năm: ");
//            int nam = int.Parse(Console.ReadLine());

//            // Kiểm tra năm nhuận
//            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
//            {
//                Console.WriteLine($"{nam} là năm nhuận.");
//            }
//            else
//            {
//                Console.WriteLine($"{nam} không phải là năm nhuận.");
//            }
//        }
//    }
//}
//bai8
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // In bảng cửu chương từ 1 đến 10
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"\n--- Bảng cửu chương {i} ---");
//                for (int j = 1; j <= 10; j++)
//                {
//                    Console.WriteLine($"{i} x {j} = {i * j}");
//                }
//            }
//        }
//    }
//}
//bai9
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình hiển thị tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập số nguyên dương n
//            Console.Write("Nhập một số nguyên dương n: ");
//            int n = int.Parse(Console.ReadLine());

//            if (n < 0)
//            {
//                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
//                return;
//            }

//            // Tính giai thừa
//            long giaiThua = 1;
//            for (int i = 2; i <= n; i++)
//            {
//                giaiThua *= i;
//            }

//            // Hiển thị kết quả
//            Console.WriteLine($"{n}! = {giaiThua}");
//        }
//    }
//}
//bai10
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Cấu hình tiếng Việt
//            Console.OutputEncoding = Encoding.UTF8;

//            // Nhập số cần kiểm tra
//            Console.Write("Nhập một số nguyên: ");
//            int n = int.Parse(Console.ReadLine());

//            // Kiểm tra số nguyên tố
//            if (n < 2)
//            {
//                Console.WriteLine($"{n} không phải là số nguyên tố.");
//            }
//            else
//            {
//                bool laSoNguyenTo = true;
//                for (int i = 2; i <= Math.Sqrt(n); i++)
//                {
//                    if (n % i == 0)
//                    {
//                        laSoNguyenTo = false;
//                        break;
//                    }
//                }

//                if (laSoNguyenTo)
//                {
//                    Console.WriteLine($"{n} là số nguyên tố.");
//                }
//                else
//                {
//                    Console.WriteLine($"{n} không phải là số nguyên tố.");
//                }
//            }
//        }
//    }
//}
