using System;

namespace Marriage_Ceremony
{
    interface IParentA
    {
        int getFullResult();
        string getName();
        string lastName();
    }
    class A : IParentA
    {
        public int age = 10;
        public int mul = 2;
        public int getFullResult()
        {
            return this.age * this.mul;
        }
        public string name = "Zaid";
        public string getName()
        {
            return this.name;
        }
        public string Lname = "Shah";
        public string lastName()
        {
            return this.Lname;
        }
    }
    class B : IParentA
    {
        public string Name = "Tariq";
        public string getName()
        {
            return this.Name;
        }
        public int age = 10;
        public int mul = 10;
        public int getFullResult()
        {
            return this.age * this.mul;
        }
        public string Lname = "";
        public string lastName()
        {
            return this.Lname;
        }
    }
    class Interface_Inheritance
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine($"Mul Is {obj.getFullResult()}");
            Console.WriteLine($"My First Name Is {obj.getName()}");
            Console.WriteLine($"My Full Name Is {obj.lastName()}");
            B obj1 = new B();
            Console.WriteLine($"My Second Name Is {obj1.getName()}");
            Console.WriteLine($"Mul Is {obj1.getFullResult()}");
        }
    }
}
