using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_68
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
                    int x = rand.Next(100, 200);
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

        static void Swap(int a_42, int b_42)
        {
            int t = a_42;
            a_42 = b_42;
            b_42 = t;
        }

        static void Chia_Phan_Tu(int[] arr_42, int n_42)
        {
            int i, j, i1 = 0, j1 = 0, k;

            for(k = 0; k < n_42/2; ++k)
            {
                int min = 101;
                for(i = k; i < n_42 - k; ++i)
                {
                    for(j = i + 1; j < n_42 - k; ++j)
                    {
                        if(Math.Abs(arr_42[i] - arr_42[j] ) < min)
                        {
                            min = Math.Abs(arr_42[i] - arr_42[j]);
                            i1 = i;
                            j1 = j;
                        }
                    }
                }
                if (arr_42[i1] < arr_42[j1])
                    Swap(arr_42[i1], arr_42[j1]);
                Swap(arr_42[i1], arr_42[k]);
                Swap(arr_42[j1], arr_42[n_42 - k - 1]);

            }
            Console.Write("\n");
            for (j = i = 0; i < n_42/2; ++i)
            {              
                Console.Write(" " + arr_42[i]);               
                j += arr_42[i];
            }
            Console.Write(": " + j);

            Console.Write("\n");
            for (j1 = 0; i < n_42; ++i)
            {               
                Console.Write(" " + arr_42[i]);               
                j1 += arr_42[i];
            }          
            Console.Write(": " + j1);

            Console.Write("\nHieu nho nhat la: " + (j - j1));

        }

        static void Main(string[] args)
        {
            int[] arr_42;

            Console.Write("Nhap so phan tu mang: ");
            int n_42 = int.Parse(Console.ReadLine());

            SinhMang(out arr_42, n_42);
            HienMang(arr_42);

            Chia_Phan_Tu(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
