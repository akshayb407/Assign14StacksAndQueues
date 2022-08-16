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
            stack.Append(56);
            stack.Append(30);
            stack.Append(70);
            stack.Display();
        }
    }
}
