using System;

namespace Arrays
{
    class ArrayOp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Array: ");
            Console.WriteLine("Enter size of array: ");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[Size];
            int[] arr2 = new int[Size];
            
            for (int i = 0; i < Size; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Array: ");

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
           //copy array
            Array.Copy(arr1, arr2, Size);

            Console.WriteLine("\nCopied Array");
            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(arr2);
            Console.Write("Sorted Array: ");

            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(arr1);
            Console.Write("Reversed Array: ");

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Cleared Array:");
            Array.Clear(arr1,0, Size);
            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nstring array:");
            Console.WriteLine("Enter size of string array: ");
            int Size_str = Convert.ToInt32(Console.ReadLine());
            string[] arr3 = new string[Size_str];
            string[] arr4 = new string[Size_str];
            Console.WriteLine("enter string array elements: ");
            for (int i = 0; i < Size_str; i++)
                arr3[i] = Console.ReadLine();
            Console.WriteLine("original String array: ");
            Console.WriteLine("Copy string array: ");
            Array.Copy(arr3, 0, arr4, 0, Size_str);
            for(int i=0;i<Size_str;i++)
                Console.WriteLine(arr4[i]);
            Console.WriteLine();
            Console.WriteLine("Sorted string array: ");
            Array.Sort(arr3);
            for (int i = 0; i < Size_str; i++)
                Console.WriteLine(arr3[i]);
            Console.WriteLine("Reverse string array: ");
            Array.Reverse(arr4);
            for (int i = 0; i < Size_str; i++)
                Console.WriteLine(arr4[i]);
            Console.WriteLine("Clear string array: ");
            Array.Clear(arr3 , 0, Size_str);
            for (int i = 0; i < Size_str; i++)
                Console.WriteLine(arr3[i]);
        }
    }
}
