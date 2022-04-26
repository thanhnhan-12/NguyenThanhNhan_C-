using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class PhuongTrinhBac_2
    {
        private int a_242, b_242, c_242;

        public PhuongTrinhBac_2()
        {

        }

        public PhuongTrinhBac_2(int a_242, int b_242, int c_242)
        {
            this.A_242 = a_242;
            this.B_242 = b_242;
            this.C_242 = c_242;
        }

        public int A_242 { get => a_242; set => a_242 = value; }
        public int B_242 { get => b_242; set => b_242 = value; }
        public int C_242 { get => c_242; set => c_242 = value; }

        public int Delta()
        {
            int d_242;
            d_242 = (b_242 * b_242) - 4 * a_242 * c_242;
            return d_242;
        }

        public void TinhNghiem() 
        {

            if (a_242 == 0)
            {
                if (b_242 != 0)
                    Console.Write("Phuong trinh co 1 nghiem x = " + (-c_242 / b_242));
                if (b_242 == 0)
                {
                    if (c_242 == 0)
                        Console.Write("Phuong trinh vo so nghiem");
                    else
                        Console.Write("Phuong trinh vo nghiem");
                }
            }
            else
            {
                int d_242 = (b_242 * b_242) - (4 * a_242 * c_242);
                if (d_242 < 0)
                    Console.Write("Phuong trinh vo nghiem");
                else
                {
                    if (d_242 == 0)
                    {
                        Console.Write("Phuong trinh co nghiem kep x1 = x2 = " + (-b_242 / (2 * a_242)));
                    }
                    else
                    {
                        if (d_242 > 0)
                        {
                            x1_242 = (-b_242 + Math.Sqrt(d_242)) / (2 * a_242);
                            x2_242 = (-b_242 - Math.Sqrt(d_242)) / (2 * a_242);
                            Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                            Console.WriteLine("x1 = " + x1_242);
                            Console.WriteLine("x2 = " + x2_242);
                        }
                    }
                }
            }
        }

    }

    class NguyenThanhNhan_1911505310242
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
