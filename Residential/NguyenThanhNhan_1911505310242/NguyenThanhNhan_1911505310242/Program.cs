using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NguyenThanhNhan_1911505310242
{
    /*Nguoi*/
    class Nguoi
    {
        private string hoten_242;
        private int tuoi_242;
        private string nghenghiep_242;
        private int cmnd_242;

        public Nguoi()
        {
        }

        public Nguoi(string hoten_242, int tuoi_242, string nghenghiep_242, int cmnd_242)
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

        public virtual void InputNguoi()
        {
            Console.WriteLine("Nhap Ho va Ten : ");
            hoten_242 = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep:  ");
            nghenghiep_242 = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");
            cmnd_242 = Int32.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.Write("\nHo va ten: " + hoten_242);
            Console.Write("\nTuoi: " + tuoi_242);
            Console.Write("\nNghe nghiep: " + nghenghiep_242);
            Console.Write("\nCMND: " + cmnd_242);
        }
    }
    /*HoDan*/
    class HoDan : Nguoi
    {
        private int sotv_242;
        private int sonha_242;
        private Nguoi[] thanhvien_242 = new Nguoi[10];

        public int Sotv_242 { get => sotv_242; set => sotv_242 = value; }
        public int Sonha_242 { get => sonha_242; set => sonha_242 = value; }
        internal Nguoi[] Thanhvien_242 { get => thanhvien_242; set => thanhvien_242 = value; }

        public HoDan()
        {

        }

        public HoDan(int sotv_242, int sonha_242, Nguoi[] thanhvien_242)
        {
            this.sotv_242 = sotv_242;
            this.sonha_242 = sonha_242;
            this.thanhvien_242 = thanhvien_242;
        }

        public void InputHoDan()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            sotv_242 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            sonha_242 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= Sotv_242; i++)
            {
                Console.WriteLine("Nhap so thanh vien thu " + i);
                thanhvien_242[i] = new Nguoi();
                thanhvien_242[i].InputNguoi();
            }
        }
        public override void Display()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}", Sotv_242, sonha_242);
            for (int i = 1; i <= sotv_242; i++)
            {
                Console.WriteLine("Thanh vien thu " + i);
                thanhvien_242[i].Display();
            }
        }
    }
    /*KhuPho*/
    class KhuPho
    {
        private HoDan[] dshodan_242 = new HoDan[10];
        private int sohodan_242;

        public void InputKhuPho()
        {
            Console.WriteLine("Nhap so ho dan: ");
            sohodan_242 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= sohodan_242; i++)
            {
                Console.WriteLine("Nhap so ho dan thu " + i);
                dshodan_242[i] = new HoDan();
                dshodan_242[i].InputHoDan();
            }
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i = 1; i <= sohodan_242; i++)
            {
                Console.WriteLine("Ho dan thu " + i);
                dshodan_242[i].Display();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho ql = new KhuPho();
            ql.InputKhuPho();
            Console.ReadKey();
        }
    }
}
