using System;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks And Queues Programs!");
            Console.WriteLine("Stacks Method");
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
