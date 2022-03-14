using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_242, b_242, c_242;
            double x1_242, x2_242;
            double d_242;
            Console.Write("Nhap a = ");
            a_242 = double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_242 = double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            c_242 = double.Parse(Console.ReadLine());

            //d_242 = b_242 * b_242 - 4 * a_242 * c_242;

            if (a_242 == 0)
            {
                if (b_242 != 0)
                    Console.Write("Phuong trinh co 1 nghiem x = " + (-c_242 / b_242));
                if(b_242 == 0)
                {
                    if (c_242 == 0)
                        Console.Write("Phuong trinh vo so nghiem");
                    else
                        Console.Write("Phuong trinh vo nghiem");
                }
            }
            else
            {
                 d_242 = (b_242 * b_242) - (4 * a_242 * c_242);
                if (d_242 < 0)
                    Console.Write("Phuong trinh vo nghiem");
                else
                {
                    if (d_242 == 0)
                    {
                        Console.Write("Phuong trinh co nghiem kep x1 = x2 = " + (-b_242 / (2 * a_242)));
                    }
                    else
                    {
                        if (d_242 > 0)
                        {
                            x1_242 = (-b_242 + Math.Sqrt(d_242)) / (2 * a_242);
                            x2_242 = (-b_242 - Math.Sqrt(d_242)) / (2 * a_242);
                            Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                            Console.WriteLine("x1 = " + x1_242);
                            Console.WriteLine("x2 = " + x2_242);
                        }
                    }
                }
            }

                 
            Console.ReadKey();
        }
    }
}
