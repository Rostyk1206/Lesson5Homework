using System;

namespace Lesson5Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your hight:");
            int hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your width:");
            int width = int.Parse(Console.ReadLine());
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
