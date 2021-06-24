using DSandAlgorithms.DataStructures.Interfaces;
using System;

namespace DSandAlgorithms.DataStructures
{
    public class SinglyLinkedList<T> : ILinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        private int _size { get; set; }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            if (First == null)
            {
                First = Last = node;
                _size++;
                return;
            }

            node.Next = First;
            First = node;
            _size++;
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);

            if (First == null)
            {
                First = Last = node;
                _size++;
                return;
            }

            Last.Next = node;
            Last = node;
            _size++;
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

            if (First == Last)
            {
                First = Last = null;
                _size = 0;
                return;
            }

            Node<T> second = First.Next;
            First.Next = null;
            First = second;
            _size--;
        }

        public void DeleteLast()
        {
            if (Last == null)
                return;

            if (First == Last)
            {
                First = null;
                Last = null;
                _size = 0;
                return;
            }

            for (Node<T> node = First; node.Next != null; node = node.Next)
            {
                if (node.Next == Last)
                {
                    Last = node;
                    Last.Next = null;
                    return;
                }
            }
            _size--;
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

        public void Reverse()
        {
            if (_size == 0)
            {
                return;
            }

            Node<T> previous = First;
            Node<T> current = previous.Next;

            while(current != null)
            {
                Node<T> next = current.Next;
                current.Next = previous;

                previous = current;
                current = next;
            }

            Last = First;
            Last.Next = null;
            First = previous;
        }

        public Node<T> GetKthNode(int KthNode)
        {
            if (KthNode < 1 || KthNode > _size || _size == 0)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> current = First;
            Node<T> next = First;

            int distance = 0;

            while(distance < KthNode - 1)
            {
                next = next.Next;
                distance++;
            }

            while(next.Next != null)
            {
                current = current.Next;
                next = next.Next;
            }

            return current;
        }

        public void ReverseWithRecursion()
        {
            ReverseWithRecursion(First);
        }

        private Node<T> ReverseWithRecursion(Node<T> node)
        {
            if (node == null)
            {
                return node;
            }

            if (node.Next == null)
            {
                First = Last = node;
                return node;
            }

            Node<T> oldFirstNode = First;
            Node<T> nextNode = ReverseWithRecursion(node.Next);
            
            nextNode.Next = node;

            if (node == oldFirstNode)
            {
                Last = node;
                Last.Next = null;
            }

            return node;
        }

        public T[] ToArray()
        {
            if (First == null)
            {
                return new T[0];
            }

            T[] arr = new T[_size];

            int index = 0;
            
            for (Node<T> node = First; node != null; node = node.Next)
            {
                arr[index++] = node.Value;
            }

            return arr;
        }

        public int Size()
        {
            return _size;
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

        public void ArrayPrint(T[] arr)
        {
            Console.WriteLine("Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
