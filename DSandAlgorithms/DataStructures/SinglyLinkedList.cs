using DSandAlgorithms.DataStructures.Interfaces;
using System;

namespace DSandAlgorithms.DataStructures
{
    public class SinglyLinkedList<T> : ILinkedList<T>
    {
        public Node<T> First { get; set; }
        
        public Node<T> Last { get; set; }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            if (First == null)
            {
                First = Last = node;
                return;
            }

            node.Next = First;
            First = node;
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);

            if (First == null)
            {
                First = Last = node;
                return;
            }

            Last.Next = node;
            Last = node;
        }

        public bool Contains(T value)
        {
            for (Node<T> node = First; node != null; node = node.Next)
            {
                if (value.Equals(node.Value))
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteFirst()
        {
            if (First == null)
                return;

            First = First.Next;
        }

        public void DeleteLast()
        {
            if (Last == null)
                return;

            for (Node<T> node = First; node.Next != null; node = node.Next)
            {
                if (node.Next == Last)
                {
                    Last = node;
                    Last.Next = null;
                    return;
                }
            }
        }

        public int IndexOf(T value)
        {
            int index = 0;

            for (Node<T> node = First; node != null; node = node.Next)
            {
                if (node.Value.Equals(value))
                {
                    return index;
                }
                index++;
            }

            return -1;
        }

        public void Print()
        {
            Console.WriteLine("Linked list");
            for (Node<T> node = First; node != null; node = node.Next)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }
    }
}
