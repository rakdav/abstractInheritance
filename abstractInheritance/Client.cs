using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    class Client:Person
    {
        private string name;
        public Client(string name, int age,int sum) : base(name, age)
        {
            Sum = sum;
        }
        public int Sum { get; set; }
        public override string Name 
        {
            get { return "Mr/Ms:"+name; }
            set { name = value; }
        }

        public override void Display()
        {
            Console.WriteLine("Name:"+Name+" Age:"+Age+" Sum:"+Sum);
        }
    }
}
