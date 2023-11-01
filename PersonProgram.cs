using System;

namespace ConsoleApp12
{
    public class person
    {
        public string Name;
        public int Age;
        public string Address;
         public void SetField(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public void GetField()
            {
            Console.WriteLine($"{Name},{Age},{Address}");
            }
        
    }
    class PersonProgram
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.SetField("zaid",20,"ellahibagh");
            p.GetField();
        }
    }
}
