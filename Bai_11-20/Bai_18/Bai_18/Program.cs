using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18
{
    class Program
    {
        static void Main(string[] args)
        {
            long h_242;
            Console.Write("Nhap so gio: ");
            h_242 = long.Parse(Console.ReadLine());

            Console.WriteLine("So tuan: " + (h_242 / (24 * 7)) + " tuan" );
            Console.WriteLine("So ngay: " + (h_242 % (24 * 7)) / 24 + " ngay" );
            Console.WriteLine("So gio: " + (h_242 % (24 * 7)) % 24 + " gio");

            Console.ReadKey();
        }
    }
}
