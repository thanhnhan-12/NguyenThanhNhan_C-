using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_In_SoTuNhien
{
    class Program
    {
        static int Natural_Number(int n)
        {
            int S = 0;
            for(int i = 1; i <= n; i++)
            {
                S += i;
            }
            return S;
        }

        static void Main(string[] args)
        {
            int So;
            Console.Write("Nhap so bat ky: ");
            So = int.Parse(Console.ReadLine());
            Console.Write("Tong cua so tu nhien la: " + Natural_Number(So));

            Console.ReadKey();
        }
    }
}
