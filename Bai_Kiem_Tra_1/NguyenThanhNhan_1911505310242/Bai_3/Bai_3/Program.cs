using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static long ChuyenDoi(long bin_242)
        {
            int dec_242;
            int p_242 = 0;

            Console.Write("Nhap vao mot so thap phan: ");
            dec_242 = int.Parse(Console.ReadLine());

            while (dec_242 > 0)
            {
                bin_242 += (dec_242 % 2) * (long)(Math.Pow(10, p_242));
                ++p_242;
                dec_242 /= 2;
            }
            return bin_242;

        }


        static void Main(string[] args)
        {
            long bin_242 = 0;
            int dec_242;
            int p_242 = 0;

            //Console.Write("Nhap vao mot so thap phan: ");
            //dec_242 = int.Parse(Console.ReadLine());

            

            Console.Write("Thap phan sang nhi phan: " + ChuyenDoi(bin_242) );

            Console.ReadKey();
        }
    }
}
