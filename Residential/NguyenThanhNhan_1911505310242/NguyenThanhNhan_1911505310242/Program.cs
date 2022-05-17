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
        private string job_242;
        private string passport_242;

        public Person()
        {
            name_242     = "Nguyen Thanh Nhan";
            age_242      = 21;
            job_242      = "Sinh vien";
            passport_242 = "123456";
        }

        public Person(Person per)
        {
            name_242     = per.name_242;
            age_242      = per.age_242;
            job_242      = per.job_242;
            passport_242 = per.passport_242;
        }

        public Person(string ten_242, int tuoi_242, string nghe_242, string CMND_242)
        {
            name_242     = ten_242;
            age_242      = tuoi_242;
            job_242      = nghe_242;
            passport_242 = CMND_242; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
