using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    class Program
    {
        static void Method(int a_242, int b_242) // Bai 1
        {
            int Tong_242, Hieu_242, Tich_242;
            double Thuong_242;

            Tong_242 = a_242 + b_242;
            Hieu_242 = a_242 - b_242;
            Tich_242 = a_242 * b_242;
            Thuong_242 = a_242 / (b_242 * 1.0);

            Console.Write("\nTong la : " + Tong_242);
            Console.Write("\nHieu la : " + Hieu_242);
            Console.Write("\nTich la : " + Tich_242);
            Console.Write("\nThuong la : " + Thuong_242);
        }

        static long ChuyenDoi(long bin_242)     // Bai 3
        {
            int dec_242;
            int p_242 = 0;

            Console.Write("Nhap vao mot so thap phan: ");
            dec_242 = int.Parse(Console.ReadLine());

            while (dec_242 > 0)
            {
                bin_242 += (dec_242 % 2) * (long)(Math.Pow(10, p_242));
                ++p_242;
                dec_242 /= 2;
            }
            return bin_242;

        }

        static void ThongTin()      // Bai 4
        {
            Console.Write("Ho va ten: Nguyen Thanh Nhan");
            Console.Write("\nLop: 19T2");
            Console.Write("\nMa sinh vien: 1911505310242");
        }

        static void Main(string[] args)
        {
            int n_242;
            Console.Write("Nhap n = ");
            n_242 = int.Parse(Console.ReadLine());
            switch(n_242)
            {
                case 1:
                    int a_242, b_242;

                    Console.Write("Nhap a = ");
                    a_242 = int.Parse(Console.ReadLine());
                    Console.Write("Nhap b = ");
                    b_242 = int.Parse(Console.ReadLine());

                    Method(a_242, b_242);
                    break;

                case 2: break;

                case 3:
                    long bin_242 = 0;
                    int dec_242;
                    int p_242 = 0;
                    Console.Write("Chuyen doi thap phan sang nhi phan: " + ChuyenDoi(bin_242));
                    break;
                case 4:
                    ThongTin(); break;
                

            }

            Console.ReadKey();
        }
    }
}
