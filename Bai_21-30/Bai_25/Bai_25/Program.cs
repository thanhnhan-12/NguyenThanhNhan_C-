using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_242, b_242, c_242, LCM_242;
            Console.Write("Nhap a = ");
            a_242 = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_242 = int.Parse(Console.ReadLine());

            c_242 = (a_242 * b_242);
            
            while (a_242 != b_242)
            {
                if (a_242 > b_242)
                    a_242 -= b_242;
                else
                    b_242 -= a_242;
            }
            Console.Write("\nUSCLN = " + a_242);
            LCM_242 = c_242 / a_242;
            Console.Write("\nBSCNN = " + LCM_242);

            Console.ReadKey();
        }
    }
}
