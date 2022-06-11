using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class RoomB : Room
    {

        public RoomB(string category_242, int price_242) : base(category_242, price_242)
        {
        }

        public override string ToString()
        {
            return "RoomB{" +
                    "category='" + Category_242 + '\'' +
                    ", price=" + Price_242 +
                    '}';
        }

    }
}
