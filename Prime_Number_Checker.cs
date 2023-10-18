using System;

namespace Prime_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prime = 11;
            int num = 2;
            int flag = 0;
            while (num < Prime)
            {
                if (Prime % 2 == 0)
                {
                    flag = 1;
                    break;
                }
                num++;
            }
            if (flag == 0)
            {
                Console.WriteLine("Number Is Prime");
            }
            else
            {
                Console.WriteLine("Number Is Not Prime");
            }
        }
    }
}
