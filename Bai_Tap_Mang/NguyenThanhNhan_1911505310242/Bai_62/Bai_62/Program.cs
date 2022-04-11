using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_62
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
                    int x = rand.Next(10, 20);
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

        static int KiemTraChan(int[] arr_42, int n_42)
        {
            int TongChan_42 = 0;
            for(int i_42 = 0; i_42 < n_42; i_42++)
            {
                if(i_42 % 2 != 0  )
                {
                    if(arr_42[i_42] % 2 == 0)
                        TongChan_42 += arr_42[i_42];
                }
            }
            return TongChan_42;
        }

        static int KiemTraLe(int[] arr_42, int n_42)
        {
            int TongLe_42 = 0;
            for (int i_42 = 0; i_42 < n_42; i_42++)
            {
                if (i_42 % 2 == 0 )
                {
                    if(arr_42[i_42] % 2 != 0)
                        TongLe_42 += arr_42[i_42];
                }
            }
            return TongLe_42;
        }

        static void SoSanh(int[] arr_42, int n_42)
        {

            if(KiemTraChan(arr_42, n_42) == KiemTraLe(arr_42, n_42))
            {
                Console.Write("\nTong cac so le vi tri chan la: " + KiemTraLe(arr_42, n_42) + " bang " + "Tong cac so chan vi tri le la: " + KiemTraChan(arr_42, n_42));
            }
            else
                Console.Write("\nTong cac so le vi tri chan la: " + KiemTraLe(arr_42, n_42) + " khac " + "Tong cac so chan vi tri le la: " + KiemTraChan(arr_42, n_42));

        }

        static int GCD(int Number1_42, int Number2_42)
        {
            if (Number2_42 == 0) return Number1_42;
            return GCD(Number2_42, Number1_42 % Number2_42);
        }

        static void Prime_Number_Pair(int[] arr_42, int n_42 )
        {
            int i1, j1;
            Console.Write("\nCac cap nguyen to cung nhau:\n");
            for (i1 = 0; i1 < n_42; ++i1)
                for (j1 = i1 + 1; j1 < n_42; ++j1)
                    if (GCD(arr_42[i1], arr_42[j1]) == 1)
                        Console.Write("({0}, {1})\n", arr_42[i1], arr_42[j1]);

        }

        static void Main(string[] args)
        {
            int[] arr_42;

            Console.Write("Nhap so phan tu mang: ");
            int n_42 = int.Parse(Console.ReadLine());

            SinhMang(out arr_42, n_42);
            HienMang(arr_42);

            SoSanh(arr_42, n_42);

            Prime_Number_Pair(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
