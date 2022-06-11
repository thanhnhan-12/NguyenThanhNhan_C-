using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_1911505310242
{
    class Hotel
    {
        private List<Person> persons_242;

        public Hotel()
        {
            persons_242 = new List<Person>();
        }

        public void add(Person person)
        {
            this.persons_242.Add(person);
        }

        public void show()
        {
            foreach (Person person in persons_242)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public void delete(string passport_242)
        {
            for (int i = 0; i < persons_242.Count; i++)
            {
                if (persons_242[i].Passport_242.Equals(passport_242))
                {
                    persons_242.RemoveAt(i);
                }
            }
        }

        public Double calculator(String passport)
        {
            Double price = 0;
            for (int i = 0; i < persons_242.Count; i++)
            {
                if (persons_242[i].Passport_242.Equals(passport))
                {
                    price = persons_242[i].NumberRent_242 * persons_242[i].Room_242.Price_242;
                }
                else
                {
                    return 0;
                }
            }
            return price;
        }

    }
}
