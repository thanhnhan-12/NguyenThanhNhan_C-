using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_In_Tuoi
{
    class Nguoi
    {
       
        static void Main(string[] args)
        {
            Person ps = new Person();
          
            Console.Write("Nhap tuoi: ");
            ps.tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            ps.ten = Console.ReadLine();
            ps.Tinh_Tuoi();
            Console.Write("\nTen la: " + ps.ten);

            Console.ReadKey();
        }
    }

    class Person
    {
        public int tuoi;
        public string ten;

        public Person()
        {

        }

        public Person(int Tuoi, string Ten)
        {
            this.Tuoi = Tuoi;
            this.Ten = Ten;
        }

        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Ten { get => ten; set => ten = value; }

        public void Tinh_Tuoi()
        {
            if (this.Tuoi >= 60)
                Console.Write("\nNguoi gia");
            else
            {
                if (this.Tuoi >= 18 && this.Tuoi < 60)
                    Console.Write("\nNguoi lon");
                else
                    Console.Write("\nEm be");
            }
        }
    }
}
