using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai_58
{
    class Program
    {
        static void Erastosthenes(int n_42)
        {
            bool[] check_42 = new bool[n_42 + 1];

            for (int i_42 = 2; i_42 <= n_42; i_42++)
            {
                check_42[i_42] = true;
            }

            for (int i_42 = 2; i_42 <= n_42; i_42++)
            {
                if (check_42[i_42] == true)
                {
                    for (int j_42 = 2 * i_42; j_42 <= n_42; j_42 += i_42)
                    {
                        check_42[j_42] = false;
                    }
                }
            }

            for (int i_42 = 2; i_42 <= n_42; i_42++)
            {
                if (check_42[i_42] == true)
                {
                    Console.Write(" " + i_42);
                }
            }
        }

        static void Main(string[] args)
        {
            int n_42;
            Console.Write("Nhap so bat ky: ");
            n_42 = int.Parse(Console.ReadLine());
            
            Erastosthenes(n_42);

            Console.ReadKey();
        }
    }
}
