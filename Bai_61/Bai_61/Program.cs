using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_61
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

        static int Tong(int[] arr_42, int n_42)       // Tính tổng các số nguyên dương có trong mảng.
        {
            int S_42 = 0;
            for(int i_42 = 0; i_42 < n_42; i_42++)
            {
                if (arr_42[i_42] > 0)
                {
                    S_42 += arr_42[i_42];
                }
            }
            return S_42;
        }

        static void Xoa(int[] arr_42, int n_42)
        {
            int p;
            Console.Write("\nNhap vi tri can xoa: ");
            p = int.Parse(Console.ReadLine());
            for (int i_42 = p + 1; i_42 < n_42; ++i_42)
                arr_42[i_42 - 1] = arr_42[i_42];
            n_42--;

            Console.Write("\nMang sau khi xoa: ");
            for (int i_42 = 0; i_42 < n_42; ++i_42)
                Console.Write(" " + arr_42[i_42]);

        }

        static void Main(string[] args)
        {
            int[] arr_42;
            
            Console.Write("Nhap so phan tu mang: ");
            int n_42 = int.Parse(Console.ReadLine());

            SinhMang(out arr_42, n_42);
            HienMang(arr_42);
            Console.Write("\nTong la: " + Tong(arr_42, n_42));

            Xoa(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
