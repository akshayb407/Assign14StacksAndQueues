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
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            int element = stack.peek();
            Console.WriteLine("Peeked element is " + element);
            int popedElement = stack.Pop();
            Console.WriteLine("Popped elemment is " + popedElement);
            int element1 = stack.peek();
            Console.WriteLine("Peeked element is " + element1);
            int popedElement1 = stack.Pop();
            Console.WriteLine("Popped elemment is " + popedElement1);
            int element2 = stack.peek();
            Console.WriteLine("Peeked element is " + element2);
            int popedElement2 = stack.Pop();
            Console.WriteLine("Popped element is " + popedElement2);
            stack.Pop();
            Console.WriteLine("Popped element is "  );
            stack.Display();
        }
    }
}
