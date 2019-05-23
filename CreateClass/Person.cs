using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Gender { Male, Female }
    public class Person
    {
        public String Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }

        public Person(string name, DateTime birthDate, string gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = (Gender)Enum.Parse(typeof(Gender), gender);
        }
        public override string ToString()
        {
            return "Person: " + Name + " " + BirthDate + " " + Gender;
        }
    }
}
