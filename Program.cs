using System;

namespace Staircase_Problem
{
    class Program
    {   //There exists a staircase with N steps, and you can climb 1 or 2 steps at a time.
        //Given N, write a function to return the number of unique ways to climb the staircase.
        //ie: N=4; 5 unique ways.
        static void Main(string[] args)
        {
            CountingStairs Stairs = new CountingStairs { };
            Console.Write("How many stairs are we climbing today? ");
            long n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Awesome! Why not make it interesting and climb the {n} stairs all {Stairs.UniqueWays(n)} different ways?");
            
            // Don't enter more than like 35-ish... Or do; it's whatever... //

            //PAUSE//
            Console.ReadLine();
        }
    }
    class CountingStairs
    {
        public long UniqueWays(long n)
        {
            switch (Math.Abs(n))
            {
                case 0:
                case 1:
                    return 1;
                default:
                    return (UniqueWays(n - 1) + UniqueWays(n - 2));
            }
        }
    }
}
