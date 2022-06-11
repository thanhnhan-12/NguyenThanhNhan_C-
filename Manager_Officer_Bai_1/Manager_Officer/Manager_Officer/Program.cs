using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Officer
{
    /* Cán bộ */
    class CanBo
    {
        private string hoTen_242;
        private int tuoi_242;
        private string gioiTinh_242;
        private string diaChi_242;

        public CanBo()
        {

        }

        public CanBo(string hoTen_242, int tuoi_242, string gioiTinh_242, string diaChi_242)
        {
            this.HoTen_242 = hoTen_242;
            this.Tuoi_242 = tuoi_242;
            this.GioiTinh_242 = gioiTinh_242;
            this.DiaChi_242 = diaChi_242;
        }

        public string HoTen_242 { get => hoTen_242; set => hoTen_242 = value; }
        public int Tuoi_242 { get => tuoi_242; set => tuoi_242 = value; }
        public string GioiTinh_242 { get => gioiTinh_242; set => gioiTinh_242 = value; }
        public string DiaChi_242 { get => diaChi_242; set => diaChi_242 = value; }

        //public virtual void Nhap_CanBo()
        //{
        //    Console.Write("\n_ Nhap Ho va Ten : ");
        //    hoTen_242 = Console.ReadLine();
        //    Console.Write("_ Nhap tuoi: ");
        //    tuoi_242 = Int32.Parse(Console.ReadLine());
        //    Console.Write("_ Nhap gioi tinh: ");
        //    gioiTinh_242 = Console.ReadLine();
        //    Console.Write("_ Nhap dia chi: ");
        //    diaChi_242 = Console.ReadLine();
        //}

        //public virtual void Xuat_CanBo()
        //{
        //    Console.Write("\n=> Ho va ten: " + hoTen_242);
        //    Console.Write("\n=> Tuoi: " + tuoi_242);
        //    Console.Write("\n=> Gioi tinh: " + gioiTinh_242);
        //    Console.Write("\n=> Dia chi: " + diaChi_242);
        //    Console.WriteLine("");
        //}

    }

    /* Công nhân */
    class CongNhan : CanBo
    {
        private int bac_242;

        public CongNhan()
        {

        }        

        public CongNhan(string hoTen_242, int tuoi_242, string gioiTinh_242, string diaChi_242, int bac_242) 
                : base(hoTen_242, tuoi_242, gioiTinh_242, diaChi_242)
        {
            this.Bac_242 = bac_242;
        }

        public int Bac_242 { get => bac_242; set => bac_242 = value; }
    }

    /* Kỹ sư */
    class KySu : CanBo
    {
        private string nganhDaoTao_242;

        public KySu()
        {

        }

        public KySu(string hoTen_242, int tuoi_242, string gioiTinh_242, string diaChi_242, string nganhDaoTao_242)
                : base(hoTen_242, tuoi_242, gioiTinh_242, diaChi_242)
        {
            this.NganhDaoTao_242 = nganhDaoTao_242;
        }

        public string NganhDaoTao_242 { get => nganhDaoTao_242; set => nganhDaoTao_242 = value; }
    }

    /* Nhân viên */
    class NhanVien : CanBo
    {
        private string congViec_242;

        public NhanVien()
        {

        }

        public NhanVien(string hoTen_242, int tuoi_242, string gioiTinh_242, string diaChi_242, string congViec_242)
                : base(hoTen_242, tuoi_242, gioiTinh_242, diaChi_242)
        {
            this.CongViec_242 = congViec_242;
        }

        public string CongViec_242 { get => congViec_242; set => congViec_242 = value; }
    }

    /* Quản lý cán bộ */
    class QuanLyCanBo
    {
        
        CongNhan CN_242 = new CongNhan();
        KySu KS_242 = new KySu();
        NhanVien NV_242 = new NhanVien();

        public void Them_QLCB()
        {           
            Console.Write("\n_Nhap ho ten cua cong nhan: ");
            CN_242.HoTen_242 = Console.ReadLine();
            Console.Write("\n_Nhap tuoi cua cong nhan: ");
            CN_242.Tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("\n_Nhap gioi tinh cua cong nhan: ");
            CN_242.GioiTinh_242 = Console.ReadLine();
            Console.Write("\n_Nhap dia chi cua cong nhan: ");
            CN_242.DiaChi_242 = Console.ReadLine();
            /*----------------------------------------------*/

            Console.Write("------------------------------");
            Console.Write("\n_Nhap ho ten cua ky su: ");
            KS_242.HoTen_242 = Console.ReadLine();
            Console.Write("\n_Nhap tuoi cua ky su: ");
            KS_242.Tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("\n_Nhap gioi tinh cua ky su: ");
            KS_242.GioiTinh_242 = Console.ReadLine();
            Console.Write("\n_Nhap dia chi cua ky su: ");
            KS_242.DiaChi_242 = Console.ReadLine();
            Console.Write("------------------------------");
            /*----------------------------------------------*/

            Console.Write("\n_Nhap ho ten cua nhan vien: ");
            NV_242.HoTen_242 = Console.ReadLine();
            Console.Write("\n_Nhap tuoi cua nhan vien: ");
            NV_242.Tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("\n_Nhap gioi tinh cua nhan vien: ");
            NV_242.GioiTinh_242 = Console.ReadLine();
            Console.Write("\n_Nhap dia chi cua nhan vien: ");
            NV_242.DiaChi_242 = Console.ReadLine();
        }

        public void Xuat_QLCB() 
        {
            Console.Write("\n=> Ho ten cua cong nhan: " + CN_242.HoTen_242);
            Console.Write("\n=> Tuoi cua cong nhan: " + CN_242.Tuoi_242);
            Console.Write("\n=> Gioi tinh cua cong nhan: " + CN_242.GioiTinh_242);
            Console.Write("\n=> Dia chi cua cong nhan: " + CN_242.DiaChi_242);
            /*----------------------------------------------*/

            Console.Write("\n------------------------------");
            Console.Write("\n=> Ho ten cua ky su: " + KS_242.HoTen_242);
            Console.Write("\n=> Tuoi cua ky su: " + KS_242.Tuoi_242);
            Console.Write("\n=> Gioi tinh cua ky su: " + KS_242.GioiTinh_242);
            Console.Write("\n=> Dia chi cua ky su: " + KS_242.DiaChi_242);
            Console.Write("\n------------------------------");
            /*----------------------------------------------*/

            Console.Write("\n=> Ho ten cua nhan vien: " + NV_242.HoTen_242);
            Console.Write("\n=> Tuoi cua nhan vien: " + NV_242.Tuoi_242);
            Console.Write("\n=> Gioi tinh cua nhan vien: " + NV_242.GioiTinh_242);
            Console.Write("\n=> Dia chi cua nhan vien: " + NV_242.DiaChi_242);
            Console.WriteLine("");
            Console.WriteLine("");
        }

         
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyCanBo QLCB_242 = new QuanLyCanBo();         
            
            while(true)
            {
                Console.WriteLine("1. Them moi can bo: ");
                Console.WriteLine("2. Tim kiem theo ho ten: ");
                Console.WriteLine("3. Hien thi danh sach: ");
                Console.WriteLine("4. Thoat chuong trinh: ");

                int ChucNang_242;
                Console.Write("\nChon chuc nang bat ky: ");
                ChucNang_242 = Int32.Parse(Console.ReadLine());

                switch (ChucNang_242)
                {
                    case 1: QLCB_242.Them_QLCB();
                            Console.WriteLine("Them thanh cong ");
                            break;

                    case 3:                            
                            Console.Write("Danh sach: ");
                            QLCB_242.Xuat_QLCB();
                            
                            break;

                    case 0:
                        Console.WriteLine("\nThoat chuong trinh!");
                        return;

                }

            }

                    
        }
    }
}
