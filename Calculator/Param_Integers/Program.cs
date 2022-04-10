using System;

namespace Param_Integers
{
    public class Program
    {
        static void SumofIntegers(params int[] integers)
        {
            int result = 0;
            foreach (int i in integers)
            {
                result += i;
            }
            Console.WriteLine("Sum of Integers:{0}", result);
        }
        static void Main()
        {
            Console.WriteLine("Enter no.of integers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] integers = new int[n];
            for (int i = 0; i < n; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumofIntegers(integers);
        }
    }
}
