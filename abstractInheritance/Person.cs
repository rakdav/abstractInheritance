using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    abstract class Person
    {
        public abstract string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Display();
    }
}
