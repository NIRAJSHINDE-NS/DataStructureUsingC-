namespace DataStructure
{
    using System;

    class LinkedListStack
    {
        private Node top;

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }
    }

}