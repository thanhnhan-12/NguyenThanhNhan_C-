using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S_242, V_242;
            Console.Write("Nhap ban kinh: ");
            int R_242 = int.Parse(Console.ReadLine());

            const double pi = 3.14;

            S_242 = 4 * pi * Math.Pow(R_242, 2);
            //Console.Write("Dien tich mat cau: " + S_242);
            V_242 = S_242 * R_242 / 3;
            Console.Write("The tich mat cau: " + V_242);

            Console.ReadKey();
        }
    }
}
