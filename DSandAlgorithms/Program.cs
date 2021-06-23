using DSandAlgorithms.DataStructures;
using DSandAlgorithms.DataStructures.Interfaces;
using System;
using System.Collections.Generic;

namespace DSandAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic arrays
            //DynamicArray<int> dynamicArray = new DynamicArray<int>(3);
            //dynamicArray.Insert(1);
            //dynamicArray.Insert(2);
            //dynamicArray.Insert(3);
            //dynamicArray.ToString();
            //dynamicArray.Insert(4);
            //dynamicArray.ToString();
            //dynamicArray.Insert(5);
            //dynamicArray.ToString();
            //dynamicArray.RemoveAt(0);
            //dynamicArray.RemoveAt(1);
            //dynamicArray.ToString();
            #endregion

            #region LinkedList
            ILinkedList<int> linkedList = new SinglyLinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.Print();
            linkedList.AddFirst(5);
            linkedList.Print();
            Console.WriteLine(linkedList.Contains(5));
            linkedList.DeleteLast();
            linkedList.Print();
            linkedList.DeleteFirst();
            linkedList.Print();
            Console.WriteLine(linkedList.IndexOf(10));
            Console.WriteLine(linkedList.IndexOf(20));
            #endregion

            Console.ReadLine();
        }
    }
}
