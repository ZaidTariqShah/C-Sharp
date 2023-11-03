using System;

namespace Practiceee
{
    public class Building
    {
        private int _age;
        private string _address;
        private string _name;
        public Building(int age, string address, string name)
        {
            this._age = age;
            this._address = address;
            this._name = name;
        }
        public Building(int age,string name)
        {
            this._age = age;
            this._name = name;
        }

        public Building(string address)
        {
            this._address = address;
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetAddress()
        {
            return _address;
        }
        public string GetName()
        {
            return _name;
        }
    }
    class Building_Constructor
    {
        static void Main(string[] args)
        {
            Building Office = new Building(20,"ellahi Bagh","Zaid Tariq Shah");
            Console.WriteLine(Office.GetName());
            Console.WriteLine(Office.GetAddress());
            Console.WriteLine(Office.GetAge());

            Building Office1 = new Building(21, "zaidu");
            Console.WriteLine(Office1.GetName());
            Console.WriteLine(Office1.GetAge());

            Building Office2 = new Building("Saudi Arabia");
            Console.WriteLine(Office2.GetAddress());
        }
    }
}
