using System;

namespace Average_Marks
{
    class Average
    {
        static void Main()
        {
            int[] avg_marks = new int[5];
            int Max_Marks = 0;
            Console.WriteLine("Enter the Average Marks of 5 students: ");
            for (int i = 0; i < 5; i++)
            {
                avg_marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Max_Marks = (avg_marks[i] > Max_Marks) ? avg_marks[i] : Max_Marks;
            }
            Console.WriteLine("Highest Marks: {0}", Max_Marks);
        }
    }
}

