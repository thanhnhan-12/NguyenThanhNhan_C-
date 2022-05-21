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

        public virtual void Input_Person()
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

        public virtual void Output_Person()
        {
            Console.Write("Ho ten: " + hoten_242);
            Console.Write("Tuoi: " + tuoi_242);
            Console.Write("Nghe nghiep: " + nghenghiep_242);
            Console.Write("CMND: " + cmnd_242);
        }

    }

    // Xây dựng lớp HoGiaDinh (Family) để quản lý thông tin của từng hộ gia đình
    class Family : Person
    {
        private int soThanhVien_242;
        private int soNha_242;
        private Person[] nguoi_242 = new Person[50];

        public Family()
        {

        }

        public Family(int soThanhVien_242, int soNha_242, Person[] nguoi_242)
        {
            this.SoThanhVien_242 = soThanhVien_242;
            this.SoNha_242 = soNha_242;
            this.Nguoi_242 = nguoi_242;
        }

        public int SoThanhVien_242 { get => soThanhVien_242; set => soThanhVien_242 = value; }
        public int SoNha_242 { get => soNha_242; set => soNha_242 = value; }
        internal Person[] Nguoi_242 { get => nguoi_242; set => nguoi_242 = value; }

        public void Input_Family()
        {
            Console.Write("--------------------------");
            Console.Write("\nNhap so thanh vien: ");
            soThanhVien_242 = Int32.Parse(Console.ReadLine());
            Console.Write("\nNhap so nha: ");
            soNha_242 = Int32.Parse(Console.ReadLine());
            for(int i_242 = 0; i_242 < soThanhVien_242; i_242++)
            {
                Console.Write("\nNhap so thanh vien thu " + i_242);
                Person nguoi_242 = new Person();
                nguoi_242.Input_Person();
            }
        }

        public void Output_Family()
        {
            Console.Write("So thanh vien: " + soThanhVien_242);
            Console.Write("So nha: " + soNha_242);
            for (int i_242 = 0; i_242 < soThanhVien_242; i_242++)
            {
                Console.Write("\nNhap so thanh vien thu " + i_242);
                Person nguoi_242 = new Person();
                nguoi_242.Output_Person();
            }
        }

    }

    // Xây dựng lớp KhuPho (Town) để quản lý các thông tin của từng hộ gia đình.
    class Town
    {
        private Family[] hogiadinh_242 = new Family[50];
        private int soHoDan_242;

        public void Input_Town()
        {
            Console.Write("\nNhap so ho dan: ");
            soHoDan_242 = Int32.Parse(Console.ReadLine());
            for(int i_242 = 0; i_242 < soHoDan_242; i_242++)
            {
                Console.Write("\nNhap so ho dan thu " + i_242);
                hogiadinh_242[i_242] = new Family();
                hogiadinh_242[i_242].Input_Family();
            }
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i_242 = 1; i_242 <= soHoDan_242; i_242++)
            {
                Console.WriteLine("Ho dan thu " + i_242);
                hogiadinh_242[i_242].Output_Family();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
