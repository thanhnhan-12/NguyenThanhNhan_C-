using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_63
{
    class Program
    {
        static void HienMang(int[] arr_42)
        {
            for (int i_42 = 0; i_42 < arr_42.Length; i_42++)
            {
                Console.Write(arr_42[i_42] + " ");
                //Console.WriteLine();
            }
        }

        static void SinhMang(out int[] arr_42, int n_42)
        {

            //Console.Write("Nhap so phan tu mang: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            if (n_42 > 0)
            {
                arr_42 = new int[n_42];
                Random rand = new Random();
                int i_42 = 0;
                while (i_42 < n_42)
                {
                    int x = rand.Next(-100, 100);
                    if (ChuaXuatHienX(arr_42, i_42, x))
                    {
                        arr_42[i_42++] = x;
                    }
                }
            }

            else
            {
                Console.WriteLine("So phan tu mang phai nguyen duong");
                arr_42 = null;
            }
        }

        static bool ChuaXuatHienX(int[] arr_42, int size_42, int x_42)
        {
            for (int i_42 = 0; i_42 < size_42; i_42++)
            {
                if (arr_42[i_42] == x_42)
                {
                    return false;
                }
            }
            return true;
        }

        static void Dem_PhanTu_Thay_PhanTuLe(int[] arr_42, int n_42 )
        {
            int c_42, i_42;
            for(c_42 = i_42 = 0; i_42 < n_42; ++i_42)
            {
                if (arr_42[i_42] % 4 == 0 && Math.Abs(arr_42[i_42]) % 10 == 6)
                    c_42++;
            }
            Console.Write("\nCo " + c_42 + " phan tu chia het cho 4, tan cung 6");

            Console.Write("\nNhan doi phan tu le: ");
            for(i_42 = 0; i_42 < n_42; ++i_42)
            {
                if (arr_42[i_42] % 2 != 0)
                    arr_42[i_42] *= 2;
            }
            for (i_42 = 0; i_42 < n_42; ++i_42)
                Console.Write(" " + arr_42[i_42]);

        }

        static void Main(string[] args)
        {
            int[] arr_42;

            Console.Write("Nhap so phan tu mang: ");
            int n_42 = int.Parse(Console.ReadLine());

            SinhMang(out arr_42, n_42);
            HienMang(arr_42);

            Dem_PhanTu_Thay_PhanTuLe(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
