using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Tam_Giac_Can_Rong
{
    class Program
    {
        static void TamGiacCan(int n)
        {
            int k;
            k = n - 1;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < 2 * n - 1; j++)
                {
                    if (j == k - i || j == k + i)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.Write("\n");
            }
            for(int i = 0; i < 2 * n - 1; i++)
                Console.Write(" * ");
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so bat ky: ");
            n = int.Parse(Console.ReadLine());
            TamGiacCan(n);

            Console.ReadKey();
        }
    }
}
