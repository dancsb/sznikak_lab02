using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace lab2
{
    [XmlRoot("Személy")]
    public class Person
    {
        public event AgeChangingDelegate AgeChanging;

        private int age;
        
        [XmlAttribute("Kor")]
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
                age = value;
            }
        }

        [XmlIgnore]
        public string Name { get; set; }
    }
}
