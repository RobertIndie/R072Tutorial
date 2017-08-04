using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial03
{
    class Tutorial04
    {
        static void Main(string[] args)
        {
            Person _072 = new Person("072", Person.Sex.Female);
            Person robert = new Person("Robert",Person.Sex.Male);
            Console.Read();
        }
    }
    class Person
    {
        public string name;
        public enum Sex
        {
            Male,Female
        }
        public Sex sex;
        public Person(string name,Sex sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
}
