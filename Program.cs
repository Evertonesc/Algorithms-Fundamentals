using System;
using Algorithms.Examples.Ex1;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[4] { 1, 44, 7, 14 };
            var value = MaxValue.Max(vector);
            Console.WriteLine(value.ToString());
        }
    }
}
