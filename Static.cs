using System;

namespace C_
{
    public static class Me
    {
        public static void addtwo(int a, int b)
        {
            int z = a + b;
            Console.WriteLine(z);
        }
        public static string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Me.addtwo(18,2);
            Console.WriteLine(Me.name = "Zaid"); 
        }
    }
}
