using System;
using System.Collections.Generic;

namespace Ex1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new();
            int n;
            
            Console.Write("Hãy nhập số xe tải cho thuê: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Họ tên: ");
                string name = Console.ReadLine();

                Console.Write("Số giờ thuê: ");
                double hours = Convert.ToDouble(Console.ReadLine());

                double money;
                if (hours <= 1)
                    money = hours * 250000;
                else
                    money = (hours - 1) * 70000 + 250000;

                persons.Add(new Person(name, hours, money));
            }

            Console.Write("\nHãy nhập số xe du lịch cho thuê: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Họ tên: ");
                string name = Console.ReadLine();

                Console.Write("Số giờ thuê: ");
                double hours = Convert.ToDouble(Console.ReadLine());

                double money;
                if (hours <= 1)
                    money = hours * 220000;
                else
                    money = (hours - 1) * 85000 + 220000;

                persons.Add(new Person(name, hours, money));
            }

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
