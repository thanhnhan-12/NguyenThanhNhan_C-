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

        static void NhapThongTinSinhVien(SinhVien [] arr_242, int n_242 )
        {
           
            for (int i_242 = 0; i_242 < n_242; i_242++)
            {
                Console.Write("\n_Nhap ho ten sinh vien thu " + i_242 + ": ");
                arr_242[i_242].HoTen_242 = Console.ReadLine();
                Console.Write("\n_Nhap ma sinh vien: ");
                arr_242[i_242].MaSV_242 = Console.ReadLine();
                Console.Write("\n_Nhap lop: ");
                arr_242[i_242].Lop_242 = Console.ReadLine();

                Console.Write("\n_Nhap diem toan: ");
                arr_242[i_242].Toan_242 = double.Parse(Console.ReadLine());
                Console.Write("\n_Nhap diem ly: ");
                arr_242[i_242].Ly_242 = double.Parse(Console.ReadLine());
                Console.Write("\n_Nhap diem hoa: ");
                arr_242[i_242].Hoa_242 = double.Parse(Console.ReadLine());
                Console.Write("<-------------------------------------->");
                
            }
           

            //if (SV.Toan_242 == (double)DiemMonHoc.DiemToan_242)
            //    Console.Write("\n Diem toan: " + SV.Toan_242);
            //else
            //    Console.Write("\nDiem toan khong dung! ");

            //if (SV.Ly_242 == (double)DiemMonHoc.DiemLy_242)
            //    Console.Write("\n Diem ly: " + SV.Ly_242);
            //else
            //    Console.Write("\nDiem ly khong dung! ");

            //if (SV.Hoa_242 == (double)DiemMonHoc.DiemHoa_242)
            //    Console.Write("\n Diem hoa: " + SV.Hoa_242);
            //else
            //    Console.Write("\nDiem hoa khong dung! ");
        }
     

        static void InThongTinSinhVien(SinhVien [] arr_242, int n_242 )
        {
            
            for(int i_242 = 0; i_242 < n_242; i_242++)
            {
                Console.Write("\n");              
                Console.Write("\n => Ho ten sinh vien: " + arr_242[i_242].HoTen_242);
                Console.Write("\n => Ma sinh vien: " + arr_242[i_242].MaSV_242);
                Console.Write("\n => Lop: " + arr_242[i_242].Lop_242);
                Console.Write("\n => Diem toan: " + arr_242[i_242].Toan_242);
                Console.Write("\n => Diem ly: " + arr_242[i_242].Ly_242);
                Console.Write("\n => Diem hoa: " + arr_242[i_242].Hoa_242);
                Console.Write("\n => Diem trung binh: " + ((arr_242[i_242].Toan_242 + arr_242[i_242].Ly_242 + arr_242[i_242].Hoa_242) / 3.0));
            }
            
        }

        //static float DiemTB(SinhVien SV)
        //{

        //}

        static void Main(string[] args)
        {                     
            int n_242;
            Console.Write("Nhap so luong sinh vien: ");
            n_242 = int.Parse(Console.ReadLine());
            SinhVien[] arr_42 = new SinhVien[n_242];

            string[] DSSV_242 = {"Sy", "1911505310248", "19T2", " 8 ", " 9 ", " 10 " };
            foreach (string ThongTin_242 in DSSV_242)
            {
                Console.Write("\nThong tin: " + ThongTin_242);               
                
            }
            Console.Write("\n<-------------------------------------->");

            NhapThongTinSinhVien( arr_42, n_242);           
            Console.Write("\n\nDanh sach thong tin cua sinh vien: ");
            InThongTinSinhVien( arr_42, n_242);

            Console.ReadKey();
        }
    }
}
