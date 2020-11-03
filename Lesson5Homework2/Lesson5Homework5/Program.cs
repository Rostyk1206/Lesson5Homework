using System;

namespace Lesson5Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int client = 10;
            int factorial = 1;

            do
            {
                factorial *= client--;
            }
            while (client > 0);

            Console.WriteLine("{0}", factorial);

        }
    }
}
