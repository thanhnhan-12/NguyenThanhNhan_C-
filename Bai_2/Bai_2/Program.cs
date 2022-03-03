using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a242;
            Console.WriteLine("Nhap 1 so bat ky tu 1 den 9: ");
            a242 = Int32.Parse(Console.ReadLine());
            switch (a242)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
                default:
                    Console.WriteLine("Nhap sai"); break;
            }

            Console.ReadKey();
        }
    }
}
