using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {

        static void Method(int a_242, int b_242)
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

        static void Main(string[] args)
        {
            int a_242, b_242;
            
            Console.Write("Nhap a = ");
            a_242 = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_242 = int.Parse(Console.ReadLine());

            Method(a_242, b_242);

            Console.ReadKey();
        }
    }
}
