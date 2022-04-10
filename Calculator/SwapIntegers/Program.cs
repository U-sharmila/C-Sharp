using System;

namespace SwapIntegers
{
    class Swapping
    {
        static void Swap(ref int Number1, ref int Number2)
        {
            int temp = Number1;
            Number1 = Number2;
            Number2 = temp;
        }
        static void Main()
        {
            int Number1, Number2;
            Console.WriteLine("Enter number1: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping:\n Number1:{0}\n Number2:{1}", Number1, Number2);
            Swap(ref Number1, ref Number2);
            Console.WriteLine("After swapping:\n Number1:{0}\n Number2:{1}", Number1, Number2);

        }
    }
}
