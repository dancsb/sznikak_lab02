using System;

namespace lab2
{

    public delegate void AgeChangingDelegate(int oldAge, int newAge);
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Age = 17;
            p.Age++;
            p.Name = "Luke";

            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);

            //p.Age = -3;
        }
    }
}