namespace DataStructure
{
    using System;

    class LinkedList
    {
        private Node head;

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

}