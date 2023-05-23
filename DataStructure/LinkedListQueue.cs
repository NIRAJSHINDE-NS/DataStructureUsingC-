namespace DataStructure
{
    using System;

    class LinkedListQueue
    {
        private Node front;
        private Node rear;

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }
    }

}