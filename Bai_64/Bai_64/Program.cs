using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_64
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


        static void Xoa_Phan_Tu(int[] arr_42, int n_42)
        {
            int i_42, c_42, x_42;
            Console.Write("\nNhap so bat ky de xoa: ");
            x_42 = int.Parse(Console.ReadLine());
            for(c_42 = i_42 = 0; i_42 < n_42; ++i_42)
            {
                if (arr_42[i_42] != x_42)
                    arr_42[c_42++] = arr_42[i_42];
            }
            n_42 = c_42;
            Console.Write("\nMang sau khi xoa: ");
            for (i_42 = 0; i_42 < n_42; ++i_42)
                Console.Write(" " + arr_42[i_42]);
            
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

            

            Xoa_Phan_Tu(arr_42, n_42);
           

            Console.ReadKey();
        }
    }
}
