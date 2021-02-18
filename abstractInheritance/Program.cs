using System;

namespace abstractInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            Client c1 = new Client("Tom",34,20000);
            c1.Display();
            Employee e1 = new Employee("Jerry",23,"Enginner");
            e1.Display();
            Person p1 = new Client("Vasia",26,120000);
            p1.Display();
            Person p2 = new Employee("Boris",45,"Bank manager");
            p2.Display();
            Rectangle rectangle = new Rectangle(1, 1, 4, 5);
            Console.WriteLine(rectangle.Area()+" "+rectangle.Perimetr());
            Circle circle = new Circle(1, 1, 10);
            Console.WriteLine(circle.Area() + " " +circle.Perimetr());
        }
    }
}
