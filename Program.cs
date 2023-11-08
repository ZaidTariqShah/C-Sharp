using System;

namespace Inheritance
{
    class Parent
    {
        public string name;
        public int children;
        public int age;
    }
    class Child : Parent
    {
        public Child(string Name = "Zaid Tariq Shah", int Children = 7, int Age = 14)
        {
            this.name = Name;
            this.children = Children;
            this.age = Age;
        }
        public int GetValues()
        {
            return this.children * this.age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child pupil = new Child();
            Console.WriteLine($"My Name is {pupil.name}");
            Console.WriteLine($"The Result is {pupil.GetValues()}");

        }
    }
}
