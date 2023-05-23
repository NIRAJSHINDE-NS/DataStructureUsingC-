namespace DataStructure
{
    using System;

    class Driver
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            LinkedList linkedList = new LinkedList();

            // Test stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack:");
            while (!stack.IsEmpty())
            {
                int data = stack.Pop();
                Console.WriteLine(data);
            }

            Console.WriteLine();

            // Test queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue:");
            while (!queue.IsEmpty())
            {
                int data = queue.Dequeue();
                Console.WriteLine(data);
            }

            Console.WriteLine();

            // Test linked list
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);

            Console.WriteLine("Linked List:");
            linkedList.Display();

            Console.ReadLine();
        }
    }

}