using System;

namespace Virtual_And_Overriding
{
    public class Me
    {
        public virtual void more()
        {
            string name = "Zaid";
            int age = 20;
            int salary = 50000000;
            Console.WriteLine("It Is Virtual");
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        }
    }

    public class Mine : Me
    {
        public  void more()
        {
            string name = "Zaid Tariq Shah";
            int age = 20;
            int salary = 50000000;
            Console.WriteLine("It Is Override");
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mine obj = new Mine();
            obj.more();
        }
    }
}
