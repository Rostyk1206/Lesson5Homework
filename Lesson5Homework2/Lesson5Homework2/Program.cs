using System;

namespace Lesson5Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 10;
            int sum = 0;
            for (int i=a+1;i<b;i++)
            {
                 sum= sum+i;
            }
            
            Console.WriteLine($"Sum:{sum}");
            for (int i=a+1;i<b;i++)
            {
                if((i%2)!=0)
                {
                    Console.WriteLine($"I={i}");
                }
            }
        }
    }
}
