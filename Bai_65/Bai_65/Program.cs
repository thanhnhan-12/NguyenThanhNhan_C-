using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_65
{
    class Program
    {
        static void Input_arr_42ay(int[] arr_42, int n_42)
        {
            for (int i_42 = 0; i_42 < n_42; i_42++)
            {
                Console.Write("arr_42[" + i_42 + "] = ");
                arr_42[i_42] = int.Parse(Console.ReadLine());
            }
        }

        static void Output_arr_42ay(int[] arr_42, int n_42)
        {
            for (int i_42 = 0; i_42 < n_42; i_42++)
                Console.Write(arr_42[i_42] + " ");
        }

        static void Xoa_Phan_Tu_Trung_Lap(int[] arr_42, int n)
        {
            int i, j, c;

            for (i = 0; i < n - 1; ++i)
            {
                for (c = j = i + 1; j < n; ++j)
                    if (arr_42[j] != arr_42[i])
                        arr_42[c++] = arr_42[j];
                n = c;
            }
            Console.Write("\nMang sau khi xoa: ");
            for (i = 0; i < n; ++i)
                Console.Write(" " + arr_42[i]);

        }

        static void Trung_Binh_Cong(int[] arr_42, int n_42)
        {
            int i_42, S_42 = 0, Count_42 = 0 ;
            double a_42;
            for(i_42 = 0; i_42 < n_42; i_42++)
            {
                if (arr_42[i_42] % 2 != 0 && arr_42[i_42] < 0)
                {
                    S_42 = S_42 + arr_42[i_42];
                    Count_42 = Count_42 + 1;
                }
                
            }
            a_42 = (float)S_42 / (Count_42 * 1.0);

            Console.Write("\nTrung binh cong cac so nguyen am le la: " + a_42);
        } 

        static void Main(string[] args)
        {
            int n_42;
            Console.Write("Nhap so phan tu cho mang: ");
            n_42 = int.Parse(Console.ReadLine());
            int[] arr_42 = new int[n_42];

            Input_arr_42ay(arr_42, n_42);
            Console.Write("Cac phan tu trong mang la: ");
            Output_arr_42ay(arr_42, n_42);
           
            Trung_Binh_Cong(arr_42, n_42);
            Xoa_Phan_Tu_Trung_Lap(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
