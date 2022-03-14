using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float a_242, b_242;
            Console.Write("Nhap a = ");
            a_242 = float.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_242 = float.Parse(Console.ReadLine());

            if (a_242 != 0)
                Console.Write("Phuong trinh co 1 nghiem duy nhat x = " + (-b_242 / a_242));
            if(a_242 == 0)
            {
                if (b_242 != 0)
                    Console.Write("Phuong trinh vo nghiem");
                else
                    Console.Write("Phuong trinh co vo so nghiem");
            }

            Console.ReadKey();
        }
    }
}
