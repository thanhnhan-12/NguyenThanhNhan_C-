using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_STRUCT_ENUM_FOREACH
{
    class NguyenThanhNhan_1911505310242
    {
        struct SinhVien
        {
            public string HoTen_242;
            public string MaSV_242;
            public string Lop_242;
            public double Toan_242;
            public double Ly_242;
            public double Hoa_242;
        }

        enum DiemMonHoc
        { 
            DiemToan_242 = 8,
            DiemLy_242 = 9,
            DiemHoa_242 = 7,
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write("\nNhap ho ten sinh vien: ");
            SV.HoTen_242 = Console.ReadLine();
            Console.Write("\nNhap ma sinh vien: ");
            SV.MaSV_242 = Console.ReadLine();
            Console.Write("\nNhap lop: ");
            SV.Lop_242 = Console.ReadLine();
          
            Console.Write("\nNhap diem toan: ");
            SV.Toan_242 = double.Parse(Console.ReadLine());
            Console.Write("\nNhap diem ly: ");
            SV.Ly_242 = double.Parse(Console.ReadLine());
            Console.Write("\nNhap diem hoa: ");
            SV.Hoa_242 = double.Parse(Console.ReadLine());


            if (SV.Toan_242 == (double)DiemMonHoc.DiemToan_242)
                Console.Write("\n Diem toan: " + SV.Toan_242);
            else
                Console.Write("\nDiem toan khong dung! ");

            if (SV.Ly_242 == (double)DiemMonHoc.DiemLy_242)
                Console.Write("\n Diem ly: " + SV.Ly_242);
            else
                Console.Write("\nDiem ly khong dung! ");

            if (SV.Hoa_242 == (double)DiemMonHoc.DiemHoa_242)
                Console.Write("\n Diem hoa: " + SV.Hoa_242);
            else
                Console.Write("\nDiem hoa khong dung! ");
        }
        

        static void InThongTinSinhVien(SinhVien SV)
        {
            Console.Write("\n Ho ten sinh vien: " + SV.HoTen_242);
            Console.Write("\n Ma sinh vien: " + SV.MaSV_242);
            Console.Write("\n Lop: " + SV.Lop_242);
            Console.Write("\n Diem toan: " + SV.Toan_242);
            Console.Write("\n Diem ly: " + SV.Ly_242);
            Console.Write("\n Diem hoa: " + SV.Hoa_242);
        }

        //static float DiemTB(SinhVien SV)
        //{

        //}

        static void Main(string[] args)
        {
            SinhVien SV1_242 = new SinhVien();

            string[] DSSV_242 = {"Sy", "1911505310248", "19T2", " 8 ", " 9 ", " 10 " };
            foreach (string ThongTin_242 in DSSV_242)
            {
                Console.Write("\n Thong tin: " + ThongTin_242);
                Console.WriteLine("");
            }

            NhapThongTinSinhVien(out SV1_242);
            Console.Write("\nThong tin cua sinh vien: ");
            InThongTinSinhVien(SV1_242);

            Console.ReadKey();
        }
    }
}
