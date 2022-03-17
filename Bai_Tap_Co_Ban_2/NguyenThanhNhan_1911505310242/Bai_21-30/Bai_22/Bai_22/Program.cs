using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_242, i_242, Count_242, Sum_242;
            Console.Write("Nhap n = ");
            n_242 = int.Parse(Console.ReadLine());

            Console.Write("Cac uoc so: ");
            for(Count_242 = Sum_242 = 0, i_242 = 1; i_242 <= n_242; ++i_242)
            {
                if(n_242 % i_242 == 0)
                {
                    Console.Write(" " + i_242);
                    Count_242++;
                    Sum_242 += i_242;
                }
            }
            Console.WriteLine("\nCo " + Count_242 + " uoc so");
            Console.Write("Tong la: " + Sum_242);

            Console.ReadKey();
        }
    }
}
