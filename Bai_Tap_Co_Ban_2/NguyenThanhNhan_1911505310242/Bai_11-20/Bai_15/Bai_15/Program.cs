using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int d_242, m_242, y_242, S_242, i_242;
            Console.Write("Nhap ngay: ");
            d_242 = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            m_242 = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            y_242 = int.Parse(Console.ReadLine());

            S_242 = d_242;
            for(i_242 = 1; i_242 < m_242; ++i_242)
            {
                switch (i_242)
                {
                    case 4: case 6: case 9: case 11: S_242 += 30; break;
                    case 2:
                    {
                        if ((y_242 % 4 == 0 && y_242 % 100 == 0) || y_242 % 400 == 0)
                            S_242 += 29;
                            break;
                    }
                    default: S_242 += 31; break;
                }
            }
            Console.Write("Ngay thu: " + S_242);

            Console.ReadKey();
        }
    }
}
