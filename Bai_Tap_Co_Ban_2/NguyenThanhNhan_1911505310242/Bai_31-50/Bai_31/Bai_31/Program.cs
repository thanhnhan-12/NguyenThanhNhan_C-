using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_242, j_242;
            Console.WriteLine("Bang cuu chuong: ");

            for(i_242 = 1; i_242 <= 10; ++i_242)
            {
                for (j_242 = 2; j_242 <= 9; ++j_242)
                    Console.Write(j_242 + " * " + i_242 + " = " + i_242 * j_242 + " \t");
               Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
