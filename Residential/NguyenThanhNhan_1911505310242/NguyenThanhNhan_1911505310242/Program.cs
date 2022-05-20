using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NguyenThanhNhan_1911505310242
{
    // Xây dựng lớp Nguoi (Person) để quản lý thông tin của mỗi cá nhân.
    class Person
    {
        private string hoten_242;
        private int tuoi_242;
        private string nghenghiep_242;
        private int cmnd_242;

        public Person()
        {

        }

        public Person(string hoten_242, int tuoi_242, string nghenghiep_242, int cmnd_242)
        {
            this.Hoten_242 = hoten_242;
            this.Tuoi_242 = tuoi_242;
            this.Nghenghiep_242 = nghenghiep_242;
            this.Cmnd_242 = cmnd_242;
        }

        public string Hoten_242 { get => hoten_242; set => hoten_242 = value; }
        public int Tuoi_242 { get => tuoi_242; set => tuoi_242 = value; }
        public string Nghenghiep_242 { get => nghenghiep_242; set => nghenghiep_242 = value; }
        public int Cmnd_242 { get => cmnd_242; set => cmnd_242 = value; }

        public virtual void Input()
        {
            Console.Write("Nhap ho va ten: ");
            hoten_242 = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap nghe nghiep: ");
            nghenghiep_242 = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            cmnd_242 = Int32.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("Ho ten: " + hoten_242);
            Console.Write("Tuoi: " + tuoi_242);
            Console.Write("Nghe nghiep: " + nghenghiep_242);
            Console.Write("CMND: " + cmnd_242);
        }

    }

    // Xây dựng lớp HoGiaDinh (Family) để quản lý thông tin của từng hộ gia đình
    class Family
    {
       

    }

    // Xây dựng lớp KhuPho (Town) để quản lý các thông tin của từng hộ gia đình.
    class Town
    {
        

    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
