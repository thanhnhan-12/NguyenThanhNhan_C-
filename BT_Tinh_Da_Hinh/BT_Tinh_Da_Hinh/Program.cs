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
            int  x, y ;
            int  Dx, Dy;
            int  x1, y1;

            public virtual void Input_Coordinate()
            {
                Console.WriteLine("");
                Console.Write("_Nhap toa do diem x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("_Nhap toa do diem y: ");
                y = int.Parse(Console.ReadLine());

                Console.Write("_Nhap toa do diem Dx: ");
                Dx = int.Parse(Console.ReadLine());
                Console.Write("_Nhap toa do diem Dy: ");
                Dy = int.Parse(Console.ReadLine());
            }

            public virtual void Output_Coordinate()
            {
                Console.Write("=> P " + "(" + x + "," + y + ")" );
                Console.Write(", T " + "(" + Dx + "," + Dy + ")");
            }

            public virtual void Translation_Spells()
            {
                x1 = x + Dx;
                y1 = y + Dy;
                Console.Write("\n_Phep tinh tien: ");
                Console.Write("\n=> P1 " + "(" + x1 + "," + y1 + ")");
            }

        }

        class Triangle : Triangle_Quadrilateral         // Tam giác
        {
            int AB_242, AC_242, BC_242;
            public void Input_Tag()         // Nhập cạnh tam giác
            {
                Console.Write("_Nhap canh thu nhat: ");
                AB_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh thu hai: ");
                AC_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh thu ba: ");
                BC_242 = int.Parse(Console.ReadLine());
            }

            public void Output_Tag()        // In ra cạnh tam giác
            {
                Console.Write("=> " + AB_242);
                Console.Write("\n=> " + AC_242);
                Console.Write("\n=> " + BC_242);
            }

            public void Test_Tag()
            {
                if ((AB_242 + AC_242) > BC_242 && (AB_242 + BC_242) > AC_242 &&
                   (AC_242 + BC_242) > AB_242)
                {
                    Console.WriteLine("\nDay la Hinh tam giac ");
                }
                else
                {
                    Console.Write("\nKhong phai hinh tam giac ");
                    Console.WriteLine("\nMoi nhap lai! ");                 
                    Input_Tag();
                    Output_Tag();
                    if ((AB_242 + AC_242) > BC_242 && (AB_242 + BC_242) > AC_242 &&
                        (AC_242 + BC_242) > AB_242)
                    {
                        Console.WriteLine("\nDay la Hinh tam giac ");                      
                    }
                                                       
                }
            }

            public override void Input_Coordinate()
            {
                base.Input_Coordinate();
            }

            public override void Output_Coordinate()
            {
                base.Output_Coordinate();
            }

            public override void Translation_Spells()
            {
                base.Translation_Spells();
            }

        }

        class Parallelogram : Triangle_Quadrilateral            // Hình bình hành
        {
            int AB_242, AD_242, BC_242, CD_242;
            public void Input_Para()         // Nhập cạnh hình bình hành
            {
                Console.Write("_Nhap canh AB: ");
                AB_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh AD: ");
                AD_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh BC: ");
                BC_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh CD: ");
                CD_242 = int.Parse(Console.ReadLine());
            }

            public void Output_Para()        // In ra cạnh hình bình hành
            {
                Console.Write(" => " + AB_242);
                Console.Write("\n => " + AD_242);
                Console.Write("\n => " + BC_242);
                Console.Write("\n => " + CD_242);
            }

            public void Test_Para()
            {
                if(AB_242 == CD_242 || AD_242 == BC_242)
                {
                    Console.WriteLine("\nDay la hinh binh hanh");
                }
                else
                {
                    Console.Write("\nKhong phai hinh binh hanh ");
                    Console.WriteLine("\nMoi nhap lai! ");
                    Input_Para();
                    Output_Para();
                    if (AB_242 == CD_242 || AD_242 == BC_242)
                    {
                        Console.WriteLine("\nDay la hinh binh hanh");
                    }
                }
            }

            public override void Input_Coordinate()
            {
                base.Input_Coordinate();
            }

            public override void Output_Coordinate()
            {
                base.Output_Coordinate();
            }

            public override void Translation_Spells()
            {
                base.Translation_Spells();
            }

        }

        class Rectangle : Triangle_Quadrilateral            // Hình chữ nhật
        {
            int AB_242, AD_242, BC_242, CD_242;
            public void Input_Para()         // Nhập cạnh hình chữ nhật
            {
                Console.Write("_Nhap canh AB: ");
                AB_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh AD: ");
                AD_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh BC: ");
                BC_242 = int.Parse(Console.ReadLine());
                Console.Write("_Nhap canh CD: ");
                CD_242 = int.Parse(Console.ReadLine());
            }
        }

        class Square : Triangle_Quadrilateral               // Hình vuông
        {

        }

        static void Main(string[] args)
        {
            int n_242;
            Console.Write("Chon hinh bat ky: ");
            n_242 = int.Parse(Console.ReadLine());

            switch(n_242)
            {
                case 1: Triangle Tag = new Triangle();
                        Tag.Input_Tag();
                        Tag.Output_Tag();
                        Tag.Test_Tag();
                        /*------------------*/
                        Triangle_Quadrilateral Tag_Quad = new Triangle();
                        Tag_Quad.Input_Coordinate();
                        Tag_Quad.Output_Coordinate();
                        Tag_Quad.Translation_Spells();
                break;
                case 2: Parallelogram Para = new Parallelogram();
                        Para.Input_Para();
                        Para.Output_Para();
                        Para.Test_Para();
                        /*------------------*/
                        Triangle_Quadrilateral Para_Quad = new Parallelogram();
                        Para_Quad.Input_Coordinate();
                        Para_Quad.Output_Coordinate();
                        Para_Quad.Translation_Spells();

                break;

                default: Console.Write("Khong hop le! ");
                break;
            }


            Console.ReadKey();
        }
    }
}
