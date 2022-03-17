using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int kw_242;
            long money_242;
            Console.Write("Nhap so KW tieu thu: ");
            kw_242 = int.Parse(Console.ReadLine());

            money_242 = kw_242 * 500;

            if (kw_242 > 100)
                money_242 += (kw_242 - 100) * 300;
            if (kw_242 > 250)
                money_242 += (kw_242 - 250) * 200;
            if (kw_242 > 350)
                money_242 += (kw_242 - 350) * 500;
            Console.Write("Chi phi: " + money_242);

            Console.ReadKey();
        }
    }
}
