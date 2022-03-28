using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_So_Tien_Sau_n_Nam
{
    class Program
    {
        static double TinhTien(long PV, int n, float i)
        {
            double FV;
           
            FV = PV * Math.Pow((1 + (i / 100)), n);
            /*
                FV: giá trị của tương lai ở năm thứ n

                PV: giá trị của số vốn tại thời điểm hiện tại

                n: số năm

                i : là lãi suất  
            */

            return FV;
        }

        static void Main(string[] args)
        {
            //double FV;
            long PV;
            int n;
            float i;

            Console.Write("Nhap so tien ban dau: ");
            PV = long.Parse(Console.ReadLine());
            Console.Write("\nNhap so nam: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\nNhap lai xuat: ");
            i = float.Parse(Console.ReadLine());

            Console.Write("\nSo tien nhan duoc sau " + n + " nam la: " + TinhTien(PV, n , i));

            Console.ReadKey();
        }
    }
}
