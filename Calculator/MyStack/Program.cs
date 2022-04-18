using System;
namespace MyStack
{
    class Stack
    {
        static void Main()
        {
           int top=-1;
           int maxsize = Convert.ToInt32(Console.ReadLine());
           int[] array = new int[maxsize];
          
            int op=0;

            int push()
            {
                int val;
                if (top == maxsize-1)
                {
                    Console.WriteLine("----Overflow----");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Enter the value: ");
                    val=Convert.ToInt32(Console.ReadLine());
                    top = top + 1;
                    array[top] = val;
                    return 1;
                }
            }
            int pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("-----Underflow-----");
                    return 0;
                }
                else
                {
                    return array[top--];
                }
            }

            void Display()
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                }
            }

            
            while (op!=4)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1.Push\n2.Pop\n3.Display\n4.Exit");
                op = Convert.ToInt32(Console.ReadLine());
                
                switch(op)
                {
                    case 1:
                        push();
                        break;
                    case 2:
                        pop();
                        break;
                    case 3:
                        Display();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
                 

            }
        }
    }



    

