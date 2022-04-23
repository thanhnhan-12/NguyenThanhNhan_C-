using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tinh_Da_Hinh
{
    class Program
    {
        class Triangle_Quadrilateral
        {
            
            public virtual void Select()
            {

            }

        }

        class Triangle : Triangle_Quadrilateral
        {
            int Side1_242, Side2_242, Side3_242;
            public void Input()         // Nhập cạnh tam giác
            {
                Console.Write("Nhap canh thu nhat: ");
                Side1_242 = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh thu hai: ");
                Side2_242 = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh thu ba: ");
                Side3_242 = int.Parse(Console.ReadLine());
            }

            public void Output()        // In ra cạnh tam giác
            {
                Console.Write(" " + Side1_242);
                Console.Write("\n " + Side2_242);
                Console.Write("\n " + Side3_242);
            }

            public void Test()
            {
                if ((Side1_242 + Side2_242) > Side3_242 && (Side1_242 + Side3_242) > Side2_242 &&
                   (Side2_242 + Side3_242) > Side1_242)
                {
                    Console.Write("\nDay la Hinh tam giac ");
                }
                else
                {
                    Console.Write("\nKhong phai hinh tam giac ");
                    Console.WriteLine("\nMoi nhap lai! ");
                    Input();
                    Output();
                    if ((Side1_242 + Side2_242) > Side3_242 && (Side1_242 + Side3_242) > Side2_242 &&
                        (Side2_242 + Side3_242) > Side1_242)
                    {
                        Console.Write("\nDay la Hinh tam giac ");
                    }
                }
            }

        }

        class Parallelogram : Triangle_Quadrilateral
        {

        }

        class Rectangle : Triangle_Quadrilateral
        {

        }

        class Square : Triangle_Quadrilateral
        {

        }

        static void Main(string[] args)
        {
            Triangle Tag = new Triangle();
            Tag.Input();
            Tag.Output();
            Tag.Test();

            Console.ReadKey();
        }
    }
}
