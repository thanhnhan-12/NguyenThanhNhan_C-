using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh thu nhat: ");
            int a242 = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu hai: ");
            int b242 = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu ba: ");
            int c242 = int.Parse(Console.ReadLine());
       
            if ( ((a242 + b242) > c242) && ((a242 + c242) > b242) && ((b242 + c242) > a242) )
                Console.Write("Day la tam giac");
            else
                Console.Write("Day khong phai la tam giac");

            Console.ReadKey();
        }
    }
}
