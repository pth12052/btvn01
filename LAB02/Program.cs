//using System;
//using LAB2;
//namespace LAB2
//{
//    class Program
//    {
//        public static void NhapMang(int[] a, int n)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static int TinhTong(int[] a, int n)
//        {
//            int tong = 0;
//            for (int i = 0; i < n; i++)
//            {
//                tong += a[i];
//            }
//            return tong;
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            //Khai báo biến n
//            int n;
//            //Nhập giá trị cho biến n
//            Console.Write("Nhập n: ");
//            n = int.Parse(Console.ReadLine());
//            //Khai báo và khởi tạo mảng số nguyên có n phần tử
//            int[] a = new int[n];
//            //Gọi hàm nhập mảng
//            NhapMang(a, n);
//            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
//            Console.WriteLine($"Tổng = {TinhTong(a, n)}");
//        }
//    }
//}
//Bai1:
//using System;

//namespace LAB2
//{
//    class Bai1_TongSoChan
//    {
//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            int[] a = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }

//            int tong = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] % 2 == 0)
//                    tong += a[i];
//            }

//            Console.WriteLine($"Tổng các số chẵn = {tong}");
//        }
//    }
//}
//Bai2:
//using System;

//namespace LAB2
//{
//    class Bai2_SoNguyenToTrongMang
//    {
//        public static bool LaSoNguyenTo(int n)
//        {
//            if (n < 2) return false;
//            for (int i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                    return false;
//            }
//            return true;
//        }

//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            int[] a = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Các phần tử là số nguyên tố:");
//            for (int i = 0; i < n; i++)
//            {
//                if (LaSoNguyenTo(a[i]))
//                    Console.WriteLine($"a[{i}] = {a[i]}");
//            }
//        }
//    }
//}
//Bai3:
//using System;

//namespace LAB2
//{
//    class Bai3_DemSoAmDuong
//    {
//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            int[] a = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }

//            int soAm = 0, soDuong = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < 0)
//                    soAm++;
//                else if (a[i] > 0)
//                    soDuong++;
//            }

//            Console.WriteLine($"Số lượng số âm: {soAm}");
//            Console.WriteLine($"Số lượng số dương: {soDuong}");
//        }
//    }
//}
//Bsi4:
//using System;

//namespace LAB2
//{
//    class Bai4_TimSoLonThuHai
//    {
//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            int[] a = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }

//            int max1 = int.MinValue, max2 = int.MinValue;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > max1)
//                {
//                    max2 = max1;
//                    max1 = a[i];
//                }
//                else if (a[i] > max2 && a[i] < max1)
//                {
//                    max2 = a[i];
//                }
//            }

//            if (max2 == int.MinValue)
//                Console.WriteLine("Không tìm thấy số lớn thứ hai.");
//            else
//                Console.WriteLine($"Số lớn thứ hai là: {max2}");
//        }
//    }
//}
//Bai5:
//using System;

//namespace LAB2
//{
//    class Bai5_HoanViHaiSo
//    {
//        public static void HoanVi(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }

//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập a: ");
//            int a = int.Parse(Console.ReadLine());
//            Console.Write("Nhập b: ");
//            int b = int.Parse(Console.ReadLine());

//            HoanVi(ref a, ref b);
//            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
//        }
//    }
//}
//Bai6:
//using System;

//namespace LAB2
//{
//    class Bai6_SapXepMangTangDan
//    {
//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            double[] a = new double[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = double.Parse(Console.ReadLine());
//            }

//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (a[i] > a[j])
//                    {
//                        double temp = a[i];
//                        a[i] = a[j];
//                        a[j] = temp;
//                    }
//                }
//            }

//            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(a[i] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
