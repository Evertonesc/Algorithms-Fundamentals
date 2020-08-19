using System;
using Algorithms.Examples.Ex1;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaxValue.cs
            // int[] vector = new int[4] { 1, 44, 7, 14 };
            // var value = MaxValue.Max(vector);
            // Console.WriteLine(value.ToString());

            //MaxAndMin.cs
            int[] vectorA = new int[4] { 4, 68, 32, 22 };
            var valueA = MaxAndMin.MaxMin(vectorA);
            Console.WriteLine(valueA[0].ToString());
            Console.WriteLine(valueA[1].ToString());
        }
    }
}
