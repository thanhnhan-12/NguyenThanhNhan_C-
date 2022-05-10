using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class Program
    {
        static void Input_array(int[] arr_242, int n_242)
        {
            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                Console.Write("arr_42[" + i_242 + "] = ");
                arr_242[i_242] = int.Parse(Console.ReadLine());
            }
        }

        static void Output_array(int[] arr_242, int n_242)
        {
            for (int i_242 = 0; i_242 < n_242; i_242++)
                Console.Write(arr_242[i_242] + " ");
        }

        static void Max(int[] arr_242, int n_242)
        {
            int Max_242 = arr_242[0];
            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                if (Max_242 < arr_242[i_242])
                    Max_242 = arr_242[i_242];
            }
            Console.Write("\nSo lon nhat trong mang la: " + Max_242);
        }

        static void Min(int[] arr_242, int n_242)
        {
            int Min_242 = arr_242[0];
            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                if (Min_242 > arr_242[i_242])
                    Min_242 = arr_242[i_242];
            }
            Console.Write("\nSo nho nhat trong mang la: " + Min_242);
        }

        static void Increase(int[] arr_242, int n_242)
        {
            
            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                for (int j_242 = i_242 + 1; j_242 < n_242; j_242++)
                {
                    if (arr_242[i_242] > arr_242[j_242])
                    {
                        
                        int temp_242 = arr_242[i_242];
                        arr_242[i_242] = arr_242[j_242];
                        arr_242[j_242] = temp_242;
                    }
                }
            }
            
        }

        static void Decrease(int[] arr_242, int n_242)
        {

            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                for (int j_242 = i_242 + 1; j_242 < n_242; j_242++)
                {
                    if (arr_242[i_242] < arr_242[j_242])
                    {
                        
                        int temp_242 = arr_242[i_242];
                        arr_242[i_242] = arr_242[j_242];
                        arr_242[j_242] = temp_242;
                    }
                }
            }
            

        }

        static void Main(string[] args)
        {
            int n_242;
            Console.Write("Nhap so phan tu cho mang: ");
            n_242 = int.Parse(Console.ReadLine());
            int[] arr_242 = new int[n_242];

            Input_array(arr_242, n_242);
            Console.Write("Cac phan tu trong mang la: ");
            Output_array(arr_242, n_242);

            Max(arr_242, n_242);
            Min(arr_242, n_242);

            Console.Write("\nMang theo thu tu tang dan: ");
            Increase(arr_242, n_242);
            Output_array(arr_242, n_242);
            Console.Write("\nMang theo thu tu giam dan: ");
            Decrease(arr_242, n_242);
            Output_array(arr_242, n_242);

            Console.ReadKey();
        }
    }
}
