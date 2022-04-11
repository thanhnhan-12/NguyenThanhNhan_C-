using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_70
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

        static void DuaChanVeCuoi(int[] arr_42, int ViTri_42)
        {
            int Tam_42 = arr_42[ViTri_42];
            for(int i_42 = ViTri_42; i_42 > 0; i_42--)
            {
                arr_42[i_42] = arr_42[i_42 - 1];
            }
            arr_42[0] = Tam_42;
        }

        static void Dua_0_VaoGiua(int[] arr_42, int ViTri_42, int ViTriCuoi_42)
        {
            for(int i_42 = ViTri_42; i_42 > ViTriCuoi_42; i_42--)
            {
                arr_42[i_42] = arr_42[i_42 - 1];
            }
            arr_42[ViTriCuoi_42] = 0;
        }

        static void Chuyen_Doi_Phan_Tu(int[] arr_42, int n_42)
        {
            int i_42;
            int ViTriCuoi_42 = 0;
            for(i_42 = 0; i_42 < n_42; i_42++)
            {
                if(arr_42[i_42] % 2 != 0 && arr_42[i_42] != 0)
                {
                    DuaChanVeCuoi(arr_42, i_42);
                }
            }
            for(i_42 = 0; i_42 < n_42; i_42++)
            {
                if(arr_42[i_42] % 2 != 0 )
                {
                    ViTriCuoi_42 = i_42;
                    break;
                }
            }
            for(i_42 = 0; i_42 < n_42; i_42++)
            {
                if(arr_42[i_42] == 0)
                {
                    Dua_0_VaoGiua(arr_42, i_42, ViTriCuoi_42);
                }
            }

            Console.Write("\nMang sau khi sap xep: ");
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

           Chuyen_Doi_Phan_Tu(arr_42, n_42);

            Console.ReadKey();
        }
    }
}
