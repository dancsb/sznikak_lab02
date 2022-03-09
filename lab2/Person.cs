using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Person
    {
        public AgeChangingDelegate AgeChanging;

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new Exception("AAAAAAAAAAA");
                /*
                if (AgeChanging != null)
                    AgeChanging(age, value);
                */
                AgeChanging?.Invoke(age, value);
                age = value; }
        }

        public string Name { get; set; }
    }
}
