using System;

namespace Lesson5Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //прямокутник
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________");

            //рівносторонній трикутник
            for (int i = 1; i <= 4; i++)
            {
                for (int space = i; space < 4; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________");

            //прямокутний трикутник

           for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________________________");

            //ромб
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i <= 5)
                    {
                        if (j >= 5 - i && j <= 5 + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j >= 5 + i - 10 + 1 && j <= 5 - i + 10 - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

