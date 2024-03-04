using System;

namespace FizzBuzz
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                    Thread.Sleep(1000);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Thread.Sleep(1000);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}