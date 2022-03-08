using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi nhap so: ");
            int a242 = int.Parse(Console.ReadLine());

            if (a242 >= 0)
                Console.Write("Day la so nguyen duong");
            else
                Console.Write("Day la so nguyen am");

            Console.ReadKey();
        }
    }
}
