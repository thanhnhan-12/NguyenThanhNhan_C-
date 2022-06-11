using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class Room
    {
        private String category_242;
        private int price_242;

        public string Category_242 { get => category_242; set => category_242 = value; }
        public int Price_242 { get => price_242; set => price_242 = value; }

        public Room(string category_242, int price_242)
        {
            this.Category_242 = category_242;
            this.Price_242 = price_242;
        }



    }
}
