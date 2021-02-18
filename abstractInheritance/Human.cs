using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
