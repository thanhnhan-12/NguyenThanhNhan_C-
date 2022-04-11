using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_59
{
    class Program
    {

        static void LunarCalendar(int n_42)
        {
            string[] Can_42 = new string[10] { "Canh", "Tan", "Nham", "Quy", "Giap",
                                                "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] Chi_42 = new string[12] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu",
                                                "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.WriteLine("{0} - {1} {2}", n_42, Can_42[n_42 % 10], Chi_42[n_42 % 12]);
            Console.WriteLine("{0} - {1} {2}", n_42 + 60, Can_42[n_42 % 10], Chi_42[n_42 % 12]);
        }

        static void Main(string[] args)
        {
            int year_42;
            Console.Write("Nhap nam bat ky: ");
            year_42 = int.Parse(Console.ReadLine());
            LunarCalendar(year_42);

            Console.ReadKey();
        }
    }
}
