using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_Lab01
{
    class Student
    {
        private int SID_242;
        private string TenSV_242;
        private string Khoa_242;
        private float DiemTB_242;

        public Student()         // Constructor mặc định
        {
            SID_242 = 1;
            TenSV_242 = "Nguyen Thanh Nhan";
            Khoa_242 = "Cong nghe so";
            DiemTB_242 = 7;
        }

        public Student(Student stu)         // Constructor sao chép
        {
            SID_242 = stu.SID_242;
            TenSV_242 = stu.TenSV_242;
            Khoa_242 = stu.Khoa_242;
            DiemTB_242 = stu.DiemTB_242;
        }

        public Student(int ID_242, string Ten_242, string Kh_242, float DTB_242)        // Constructor tham số
        {
            SID_242 = ID_242;
            TenSV_242 = Ten_242;
            Khoa_242 = Kh_242;
            DiemTB_242 = DTB_242;
        }

        public int SID_2421 { get => SID_242; set => SID_242 = value; }
        public string TenSV_2421 { get => TenSV_242; set => TenSV_242 = value; }
        public string Khoa_2421 { get => Khoa_242; set => Khoa_242 = value; }
        public float DiemTB_2421 { get => DiemTB_242; set => DiemTB_242 = value; }

        public virtual void NhapDSSV(Student[] DSSV_242, int n_242)
        {
            Console.Write("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n_242; i++) //Lap n lan nhap thong tin sv
            {

                DSSV_242[i] = new Student();
                Console.Write("\nNhap MaSV {0}: ", i + 1);
                DSSV_242[i].SID_2421 = int.Parse(Console.ReadLine());
                Console.Write("\nHo ten SV: ");
                DSSV_242[i].TenSV_2421 = Console.ReadLine();
                Console.Write("\nNhap khoa: ");
                DSSV_242[i].Khoa_2421 = Console.ReadLine();
                Console.Write("\nNhap Diem TB: ");
                DSSV_242[i].DiemTB_2421 = float.Parse(Console.ReadLine());
            }
        }

        public virtual void XuatDSSV(Student[] DSSV_242, int n_242)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV_242)
                sv.Show();
        }

        public virtual void Show()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.Write("Ma sinh vien: " + this.SID_242);
            Console.Write("\nTen sinh vien: " + this.TenSV_242);
            Console.Write("\nKhoa: " + this.Khoa_242);
            Console.Write("\nDiem trung binh: " + this.DiemTB_242);
        }

    }

    class Tester : Student
    {
        static void Main(string[] args)
        {
            Student[] DSSV_242;
            int n_242;
            Console.Write("Nhap so luong sinh vien: ");
            n_242 = int.Parse(Console.ReadLine());
            DSSV_242 = new Student[n_242];

            Student S1 = new Student();
            S1.NhapDSSV(DSSV_242, n_242);
            S1.XuatDSSV(DSSV_242, n_242);

            Console.ReadKey();
        }
    }
}
