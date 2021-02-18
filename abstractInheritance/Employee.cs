using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    class Employee:Person
    {
        private string name;
        public Employee(string name, int age,string position) : base(name, age)
        {
            Position = position;
        }

        public string Position { get; set; }
        public override string Name {
            get { return name;}
            set { name = value; }
        }

        public override void Display()
        {
            Console.WriteLine("Name:"+Name+" Age:"+Age+" Position:"+Position);
        }
    }
}
