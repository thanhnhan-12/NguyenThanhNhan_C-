using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    // Xây dựng lớp Person để quản lý thông tin của mỗi cá nhân.
    class Person
    {
        private string name_242;
        private int age_242;
        private string job_242;
        private string passport_242;

        public Person()
        {
            Name_242 = "Nguyen Thanh Nhan";
            Age_242 = 21;
            Job_242 = "Sinh vien";
            Passport_242 = "123456";
        }

        public Person(Person per)
        {
            Name_242 = per.Name_242;
            Age_242 = per.Age_242;
            Job_242 = per.Job_242;
            Passport_242 = per.Passport_242;
        }

        public Person(string ten_242, int tuoi_242, string nghe_242, string CMND_242)
        {
            Name_242 = ten_242;
            Age_242 = tuoi_242;
            Job_242 = nghe_242;
            Passport_242 = CMND_242;
        }

        public string Name_242 { get => name_242; set => name_242 = value; }
        public int Age_242 { get => age_242; set => age_242 = value; }
        public string Job_242 { get => job_242; set => job_242 = value; }
        public string Passport_242 { get => passport_242; set => passport_242 = value; }

        public String toString()
        {
            return "Person{" +
                    "name='" + name_242 + '\'' +
                    ", age=" + age_242 +
                    ", job='" + job_242 + '\'' +
                    ", passport='" + passport_242 + '\'' +
                    '}';
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
