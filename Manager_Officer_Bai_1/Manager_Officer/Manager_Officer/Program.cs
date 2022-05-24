using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Officer
{
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
    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
