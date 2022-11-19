using System;

namespace Day12_practice.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $@"Hi my name is {Name} and my age is {Age}";
        }

        public int BoarnYear()
        {
            return DateTime.Today.Year - Age;
        }
    }
}