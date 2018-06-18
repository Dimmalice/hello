
using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is sleep calculator!");

            Console.WriteLine("How many hours did you sleep last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("WELL DONE");

            }
            else
            {
                Console.WriteLine("NOOOO");
            }
        }
    }
}
