using System;

namespace value
{
    public class Board
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 4 && value[0] == 'Z')
                {
                    Console.WriteLine($"The Name is {value}");
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Error! Try Again");
                }
            }
        }
    }

    class Set_Get
    {
        static void Main(string[] args)
        {
            Board pen = new Board();
            pen.Name = "Zara";    // Name should be less than 5 words
        }
    }
}
