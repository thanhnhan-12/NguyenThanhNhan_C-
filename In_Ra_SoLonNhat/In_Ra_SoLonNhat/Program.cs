using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Ra_SoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu cho mang: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Input_Array(arr, n);
            Console.Write("Cac phan tu trong mang la: ");
            Output_Array(arr, n);
            
            Max(arr,n);

            Console.ReadKey();
        }

        static void Input_Array(int[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Output_Array(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        static void Max(int[] arr, int n)
        {
            int Max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (Max < arr[i])
                    Max = arr[i];                  
            }
            Console.Write("\nSo lon nhat trong mang la: " + Max);
        }

    }
}
