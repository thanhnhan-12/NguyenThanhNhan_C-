using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh thu nhat: ");
            double a242 = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu hai: ");
            double b242 = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu ba: ");
            double c242 = double.Parse(Console.ReadLine());

      
            if (a242 == Math.Sqrt(Math.Pow(b242, 2) + Math.Pow(c242, 2)) || 
                b242 == Math.Sqrt(Math.Pow(a242, 2) + Math.Pow(c242, 2)) || 
                c242 == Math.Sqrt(Math.Pow(a242, 2) + Math.Pow(b242, 2)))
                Console.Write("Day la tam giac vuong");
            else
                Console.Write("Day khong phai la tam giac vuong");


            Console.ReadKey();
        }
    }
}
