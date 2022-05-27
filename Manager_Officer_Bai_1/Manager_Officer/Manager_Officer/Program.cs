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

        public virtual void Nhap_CanBo()
        {
            Console.Write("\n_ Nhap Ho va Ten : ");
            hoTen_242 = Console.ReadLine();
            Console.Write("_ Nhap tuoi: ");
            tuoi_242 = Int32.Parse(Console.ReadLine());
            Console.Write("_ Nhap gioi tinh: ");
            gioiTinh_242 = Console.ReadLine();
            Console.Write("_ Nhap dia chi: ");
            diaChi_242 = Console.ReadLine();
        }

        public virtual void Xuat_CanBo()
        {
            Console.Write("\n=> Ho va ten: " + hoTen_242);
            Console.Write("\n=> Tuoi: " + tuoi_242);
            Console.Write("\n=> Gioi tinh: " + gioiTinh_242);
            Console.Write("\n=> Dia chi: " + diaChi_242);
            Console.WriteLine("");
        }

    }

    /* Công nhân */
    class CongNhan : CanBo
    {
        private int bac_242;
        private int soLuong_CongNhan_242;
        private CanBo[] congNhan_242 = new CanBo[20];

        public CongNhan()
        {

        }

        public CongNhan(int Bac_242, int SoLuong_CongNhan_242, CanBo[] CongNhan_242)
        {
            this.Bac_242 = Bac_242;
            this.SoLuong_CongNhan_242 = SoLuong_CongNhan_242;
            this.CongNhan_242 = CongNhan_242;           
        }

        public int Bac_242 { get => bac_242; set => bac_242 = value; }
        public int SoLuong_CongNhan_242 { get => soLuong_CongNhan_242; set => soLuong_CongNhan_242 = value; }
        internal CanBo[] CongNhan_242 { get => congNhan_242; set => congNhan_242 = value; }

        public void Cap_Bac()
        {
            for(int i_242 = 1; i_242 <= 10; i_242++)
            {
                Console.Write("\nBac " + i_242);
            }
        }

        public override void Nhap_CanBo()
        {
            //Console.Write("\n---------------------------");
            Console.Write("Nhap so luong cong nhan: ");
            soLuong_CongNhan_242 = Int32.Parse(Console.ReadLine());
            for(int i_242 = 1; i_242 <= soLuong_CongNhan_242; i_242++)
            {
                congNhan_242[i_242] = new CanBo();
                congNhan_242[i_242].Nhap_CanBo();
            }
        }

        public override void Xuat_CanBo()
        {
            Console.Write("\nDanh sach: ");
            for (int i_242 = 1; i_242 <= soLuong_CongNhan_242; i_242++)
            {
                congNhan_242[i_242].Xuat_CanBo();
            }          
        }

    }

    /* Kỹ sư */
    class KySu : CanBo
    {
        private string nganhDaoTao_242;
        private int soLuong_KySu_242;
        private CanBo[] kySu_242 = new CanBo[20];

        public KySu()
        {

        }

        public KySu(string NganhDT_242, int SoLuong_KySu_242, CanBo[] KySu_242)
        {
            this.NganhDaoTao_242 = NganhDT_242;
            this.SoLuong_KySu_242 = SoLuong_KySu_242;
            this.KySu_242 = KySu_242;
        }

        public string NganhDaoTao_242 { get => nganhDaoTao_242; set => nganhDaoTao_242 = value; }
        public int SoLuong_KySu_242 { get => soLuong_KySu_242; set => soLuong_KySu_242 = value; }
        internal CanBo[] KySu_242 { get => kySu_242; set => kySu_242 = value; }

        public override void Nhap_CanBo()
        {
            Console.Write("\n---------------------------");
            Console.Write("\nNhap so luong ky su: ");
            soLuong_KySu_242 = Int32.Parse(Console.ReadLine());
            for (int i_242 = 1; i_242 <= soLuong_KySu_242; i_242++)
            {
                Console.Write("\nNhap nganh dao tao: ");
                nganhDaoTao_242 = Console.ReadLine();
                kySu_242[i_242] = new CanBo();
                kySu_242[i_242].Nhap_CanBo();
            }
        }

        public override void Xuat_CanBo()
        {
            Console.Write("\nDanh sach: ");
            for (int i_242 = 1; i_242 <= soLuong_KySu_242; i_242++)
            {
                //Console.Write("\nNganh dao tao: " + nganhDaoTao_242);
                kySu_242[i_242].Xuat_CanBo();
            }
        }
    }

    /* Nhân viên */
    class NhanVien : CanBo
    {
        private string congViec_242;
        private int soLuong_NhanVien_242;
        private CanBo[] nhanVien_242 = new CanBo[20];

        public NhanVien()
        {

        }

        public NhanVien(string CongViec_242, int SoLuong_NhanVien_242, CanBo[] NhanVien_242)
        {
            this.congViec_242 = CongViec_242;
            this.soLuong_NhanVien_242 = SoLuong_NhanVien_242;
            this.nhanVien_242 = NhanVien_242;
        }

        public override void Nhap_CanBo()
        {
            Console.Write("\n---------------------------");
            Console.Write("\nNhap so luong nhan vien: ");
            soLuong_NhanVien_242 = Int32.Parse(Console.ReadLine());
            for (int i_242 = 1; i_242 <= soLuong_NhanVien_242; i_242++)
            {
                Console.Write("\nNhap cong viec: ");
                congViec_242 = Console.ReadLine();
                nhanVien_242[i_242] = new CanBo();
                nhanVien_242[i_242].Nhap_CanBo();
            }
        }

        public override void Xuat_CanBo()
        {
            Console.Write("\nDanh sach: ");
            for (int i_242 = 1; i_242 <= soLuong_NhanVien_242; i_242++)
            {
                nhanVien_242[i_242].Xuat_CanBo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CongNhan congnhan_242 = new CongNhan();
            congnhan_242.Nhap_CanBo();
            congnhan_242.Xuat_CanBo();

            KySu kysu_242 = new KySu();
            kysu_242.Nhap_CanBo();
            kysu_242.Xuat_CanBo();

            NhanVien nhanvien_242 = new NhanVien();
            nhanvien_242.Nhap_CanBo();
            nhanvien_242.Xuat_CanBo();

            Console.ReadKey();
        }
    }
}
