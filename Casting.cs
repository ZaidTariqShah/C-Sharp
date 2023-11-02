using System;

namespace Casting
{
    class Casting
    {
        static void Main(string[] args)
        {
            int my = 10;                // Int to Double
            double mi = my; 
            Console.WriteLine(mi);
            Console.WriteLine(my);

            double mine = 9.78;
            int mii = (int)mine;
            Console.WriteLine(mii);
            Console.WriteLine(mine);
            double dob = 5.9;
            int into = 10;
            bool boo = true;
            Console.WriteLine(Convert.ToString(into));          // Convert int To String
            Console.WriteLine(Convert.ToDouble(into));          // Convert Int To Double
            Console.WriteLine(Convert.ToInt32(dob));            // Convert Double To int
            Console.WriteLine(Convert.ToString(boo));           // Convert Boolean To String

        }
    }
}
