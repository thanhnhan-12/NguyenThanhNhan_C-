using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NguyenThanhNhan_1911505310242
{
    /*Person*/
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

        public virtual void InputPerson()
        {
            Console.Write("\nNhap Ho va Ten : ");
            hoten_242 = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap nghe nghiep:  ");
            nghenghiep_242 = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            cmnd_242 = Int32.Parse(Console.ReadLine());
        }

        public virtual void Output_Person()
        {
            Console.Write("\n---------------------------");
            Console.Write("\nHo va ten: " + hoten_242);
            Console.Write("\nTuoi: " + tuoi_242);
            Console.Write("\nNghe nghiep: " + nghenghiep_242);
            Console.Write("\nCMND: " + cmnd_242);
        }
    }
    /*Family*/
    class Family : Person
    {
        private int soThanhVien_242;
        private int soNha_242;
        private Person[] thanhvien_242 = new Person[10];

        public int SoThanhVien_242 { get => soThanhVien_242; set => soThanhVien_242 = value; }
        public int SoNha_242 { get => soNha_242; set => soNha_242 = value; }
        internal Person[] Thanhvien_242 { get => thanhvien_242; set => thanhvien_242 = value; }

        public Family()
        {

        }

        public Family(int soThanhVien_242, int soNha_242, Person[] thanhvien_242)
        {
            this.SoThanhVien_242 = soThanhVien_242;
            this.SoNha_242 = soNha_242;
            this.Thanhvien_242 = thanhvien_242;
        }

        public void Input_Family()
        {
            Console.Write("\nNhap so thanh vien: ");
            SoThanhVien_242 = Int32.Parse(Console.ReadLine());
            Console.Write("\nNhap so Nha: ");
            SoNha_242 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= SoThanhVien_242; i++)
            {
                Console.Write("\nNhap so thanh vien thu " + i);
                Thanhvien_242[i] = new Person();
                Thanhvien_242[i].InputPerson();
            }
        }
        public override void Output_Person()
        {
            Console.WriteLine("So thanh vien: {0}, So Nha: {1}", SoThanhVien_242, SoNha_242);
            for (int i = 1; i <= SoThanhVien_242; i++)
            {
                Console.WriteLine("Thanh vien thu " + i);
                Thanhvien_242[i].Output_Person();
            }
        }
    }
    /*Town*/
    class Town
    {
        private Family[] dsFamily_242 = new Family[10];
        private int soFamily_242;

        public void InputTown()
        {
            Console.Write("Nhap so ho dan: ");
            soFamily_242 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= soFamily_242; i++)
            {
                Console.Write("\nNhap so ho dan thu " + i);
                dsFamily_242[i] = new Family();
                dsFamily_242[i].Input_Family();
            }
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i = 1; i <= soFamily_242; i++)
            {
                Console.WriteLine("Ho dan thu " + i);
                dsFamily_242[i].Output_Person();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Town ql = new Town();
            ql.InputTown();
            Console.ReadKey();
        }
    }
}
