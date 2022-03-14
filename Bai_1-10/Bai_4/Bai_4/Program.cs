using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_242, b_242, c_242;
            double S_242, P_242;
            Console.Write("Nhap canh thu nhat: ");
            a_242 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu hai: ");
            b_242 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu ba: ");
            c_242 = double.Parse(Console.ReadLine());

            if ( (b_242 + c_242) > a_242 && (a_242 + c_242) > b_242 && (a_242 + b_242) > c_242 )
            {
                if (a_242 * a_242 == b_242 * b_242 + c_242 * c_242 ||
                    b_242 * b_242 == a_242 * a_242 + c_242 * c_242 ||
                    c_242 * c_242 == a_242 * a_242 + b_242 * b_242)
                {
                    Console.WriteLine("Tam giac vuong");
                }
                else if (a_242 == b_242 && b_242 == c_242)
                {
                    Console.WriteLine("Tam giac deu");
                }
                else if (a_242 == b_242 || b_242 == c_242 || a_242 == c_242)
                {                               
                    if ((a_242 * a_242 == b_242 * b_242 + c_242 * c_242 ||
                         b_242 * b_242 == a_242 * a_242 + c_242 * c_242 ||
                         c_242 * c_242 == a_242 * a_242 + b_242 * b_242))               
                        Console.WriteLine("Tam giac vuong can");
                    else
                        Console.WriteLine("Tam giac can");
                }
                else
                    Console.WriteLine("Tam giac thuong");
                P_242 = (a_242 + b_242 + c_242) / 2;
                S_242 = Math.Sqrt(P_242 * (P_242 - a_242) * (P_242 - b_242) * (P_242 - c_242));
                Console.Write("Dien tich S = " + S_242);
            }
            else
                Console.WriteLine("Khong hop le! ");

            Console.ReadKey();
        }
    }
}
