using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class Person
    {
        private string name_242;
        private int age_242;
        private string passport_242;
        private Room room_242;
        private int numberRent_242;

        public Person(string name_242, int age_242, string passport_242, Room room_242, int numberRent_242)
        {
            this.Name_242 = name_242;
            this.Age_242 = age_242;
            this.Passport_242 = passport_242;
            this.Room_242 = room_242;
            this.NumberRent_242 = numberRent_242;
        }

        public string Name_242 { get => name_242; set => name_242 = value; }
        public int Age_242 { get => age_242; set => age_242 = value; }
        public string Passport_242 { get => passport_242; set => passport_242 = value; }
        public int NumberRent_242 { get => numberRent_242; set => numberRent_242 = value; }
        internal Room Room_242 { get => room_242; set => room_242 = value; }

        public override string ToString()
        {
            return "Person{" +
                    "name='" + Name_242 + '\'' +
                    ", age=" + Age_242 +
                    ", passport= '" + Passport_242 + '\'' + Room_242.ToString() +
                    '}';
        }

    }
}
