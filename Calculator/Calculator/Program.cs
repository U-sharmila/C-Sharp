using System;

namespace Calculator
{
    class Calculator_op
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine(" 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division\n 5.Exit");
                Console.WriteLine("Enter your Choice");
                op = Convert.ToInt32(Console.ReadLine());
                int FN, SN;
                float result = 0F;

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Enter Two Numbers: ");
                        FN = Convert.ToInt32(Console.ReadLine());
                        SN = Convert.ToInt32(Console.ReadLine());
                        result = FN + SN;
                        Console.WriteLine("Sum={0}", result);
                        break;
                    case 2:
                        Console.WriteLine("Enter Two Numbers: ");
                        FN = Convert.ToInt32(Console.ReadLine());
                        SN = Convert.ToInt32(Console.ReadLine());
                        result = FN - SN;
                        Console.WriteLine("Difference={0}", result);
                        break;
                    case 3:
                        Console.WriteLine("Enter Two Numbers: ");
                        FN = Convert.ToInt32(Console.ReadLine());
                        SN = Convert.ToInt32(Console.ReadLine());
                        result = FN * SN;
                        Console.WriteLine("Product={0}", result);
                        break;
                    case 4:
                        Console.WriteLine("Enter Two Numbers: ");
                        FN = Convert.ToInt32(Console.ReadLine());
                        SN = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            result = (float)FN / SN;
                            Console.WriteLine("Division={0}", result);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (op != 5);

        }
    }
}