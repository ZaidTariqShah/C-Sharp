using System;

namespace Validation
{
    public class Person
    {
        private string _name;

        public string getName()
        {
            return _name;
        }
        public void setName(string Name)
        {
            _name = Name;
            if(Name.Length <= 4 && Name[0] == 'Z' )
            {
                Console.WriteLine("Program Done Successfully");
            }
            else 
            {
                Console.WriteLine("Nope! Error Please Try Again");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Pupil = new Person();
            Pupil.setName("Zaid");
           string Naav =  Pupil.getName();
            Console.WriteLine($"My Name is {Naav}");
        }
    }
}
