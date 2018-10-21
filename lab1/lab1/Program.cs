using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Stack
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(5);
            stack.Push(3);

            int actualSize = 0;

            Console.WriteLine("First stack : ");
            foreach (int i in stack)
                Console.Write(i);
            Console.WriteLine("\n");

            //Actual size
            foreach (int i in stack)
                actualSize++;
            Console.WriteLine("actual size of stack is : ");
            Console.Write(actualSize);
            Console.WriteLine("\n");

            //POP
            Console.WriteLine("POP : ");
            stack.Pop();
            Console.WriteLine("Second stack : ");
            foreach (int i in stack)
                Console.Write(i);
            Console.WriteLine("\n");

            //PUSH
            Console.WriteLine("PUSH : ");
            stack.Push(9);
            Console.WriteLine("Third stack : ");
            foreach (int i in stack)
                Console.Write(i);
            Console.WriteLine("\n");

            //Get head
            Console.WriteLine("The head of the stack is ");
            foreach (int i in stack)
            {
                Console.Write(i);
                break;
            }

            Console.ReadKey();
        }
    }
}
