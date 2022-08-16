using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Stack
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public static Node head;

        public void Push(int data)
        {
            Stack stack = new Stack();
            stack.Add(data);
        }

        public bool Add(int data)
        {
            Node node = new Node(data);

            if (node == null)
            {
                head = node;
                return true;
            }
            node.next = head;
            head = node;
            return true;

        }
        public bool Append(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                return true;
            }

            Node t = head;

            while (t.next != null)
            {
                t = t.next;
            }
            t.next = node;

            return true;

        }

        public void Display()
        {
            Node t = head;

            if (t == null)
            {
                Console.WriteLine("Node is empty");
            }
            while (t.next != null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
        }

         public int peek()
         {
             if (head == null)
                 throw new NullReferenceException("empty List");
             Node t = head, p = head;
             while (t.next != null)
             {
                 p = t;
                 t = t.next;
             }
             int obj = t.data;
             return obj;
         }

         public int Pop()
         {
             if (head == null)
             {
                 throw new NullReferenceException("List is Empty");
             }
             Node t = head, p = head;
             while (t.next != null)
             {
                 p = t;
                 t = t.next;
             }
            int obj = t.data;
             p.next = null;
             return obj;
         }
       
    }
}
