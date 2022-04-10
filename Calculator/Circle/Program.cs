using System;

namespace Circle
{
    class Circle_Op
    {
        static void circleoperations(float radius)
        {
            float pi = 3.14F;
            float Area = pi * radius * radius;
            float Circumference = 2 * pi * radius;
            Console.WriteLine("Area of circle: {0}\nCircumference of circle: {1}", Area, Circumference);

        }
        static void Main()
        {

            Console.WriteLine("Enter the radius of circle: ");
            float radius = Convert.ToInt32(Console.ReadLine());
            circleoperations(radius);

        }
    }
}
