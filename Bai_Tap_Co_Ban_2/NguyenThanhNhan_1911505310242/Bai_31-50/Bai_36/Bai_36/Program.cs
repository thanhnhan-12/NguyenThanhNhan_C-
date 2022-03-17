using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_242, k_242, i_242, Count_242;
            Console.Write("Nhap so bat ky: ");
            n_242 = int.Parse(Console.ReadLine());

            k_242 = 2;
            Count_242 = 0;
            while(Count_242 < n_242)
            {
                for(i_242 = 2; i_242 * i_242 <= k_242; ++i_242)               
                    if (k_242 % i_242 == 0) break;
                if(i_242 * i_242 > k_242)
                {
                    Console.Write(" " + k_242);
                    Count_242++;
                }
                k_242++;
            }

            Console.ReadKey();
        }
    }
}
