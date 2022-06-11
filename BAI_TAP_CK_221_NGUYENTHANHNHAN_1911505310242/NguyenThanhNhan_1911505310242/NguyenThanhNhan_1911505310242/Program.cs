using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel_242 = new Hotel();
            while (true)
            {
                Console.WriteLine("===Danh sach cac chuc nang===");
                Console.WriteLine("1. Chen nguoi thue");
                Console.WriteLine("2. Xoa nguoi thue bang so ho chieu");
                Console.WriteLine("3. Tinh gia theo ho chieu");
                Console.WriteLine("4. Hien thi thong tin nguoi thue");
                Console.WriteLine("5.Thoat");

                Console.Write("\nChon chuc nang: ");
                int Option_242 = int.Parse(Console.ReadLine());
                switch (Option_242)
                {
                    case 1:
                        {
                            Console.WriteLine("_ Nhap ten:");
                            String name_242 = Console.ReadLine();
                            Console.WriteLine("_ Nhap Tuoi: ");
                            int age_242 = int.Parse(Console.ReadLine());
                            Console.WriteLine("_ Nhap passport:");
                            String passport_242 = Console.ReadLine();

                            Console.WriteLine("_ Chon phong A:");
                            Console.WriteLine("_ Chon phong B:");
                            Console.WriteLine("_ Chon phong C:");
                            String choise_242 = Console.ReadLine();
                            Room room_242;
                            if (choise_242.Equals("a"))
                            {
                                room_242 = new RoomA("A", 500);
                            }
                            else if (choise_242.Equals("b"))
                            {
                                room_242 = new RoomB("B", 300);
                            }
                            else if (choise_242.Equals("c"))
                            {
                                room_242 = new RoomC("C", 100);
                            }
                            else
                            {
                                continue;
                            }
                            Console.WriteLine("Nhap so ngay o:");
                            int day_242 = int.Parse(Console.ReadLine());
                            Person person_242 = new Person(name_242, age_242, passport_242, room_242, day_242);
                            hotel_242.add(person_242);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("\nNhap so ho chieu can xoa: ");
                            string passport_242 = Console.ReadLine();
                            hotel_242.delete(passport_242);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("\nNhap so ho chieu: ");
                            string passport_242 = Console.ReadLine();
                            Console.WriteLine("Gia tien: {0} " + hotel_242.calculator(passport_242) );
                            break;
                        }
                    case 4:
                        {
                            hotel_242.show();
                            break;
                        }
                    case 5:
                        return;
                }
            }


        }
    }
}
