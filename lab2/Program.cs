using System;
using System.Collections;
using System.Xml.Serialization;

namespace lab2
{

    public delegate void AgeChangingDelegate(int oldAge, int newAge);
    public class Program
    {

        static void PersonAgeChanging(int oldAge, int newAge)
        {
            Console.WriteLine(oldAge + " => " + newAge);
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.AgeChanging += PersonAgeChanging;
            /*
            p.AgeChanging = PersonAgeChanging;
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging -= PersonAgeChanging;
            p.AgeChanging = null;
            */

            p.Age = 17;
            p.Age++;
            p.Name = "Luke";

            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);

            //p.Age = -3;

            XmlSerializer seralizer = new XmlSerializer(typeof (Person));
            FileStream strem = new FileStream("person.txt", FileMode.Create);

            seralizer.Serialize(strem, p);
            strem.Close();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                Console.WriteLine($"Value: {num}");
            }
        }
    }
}