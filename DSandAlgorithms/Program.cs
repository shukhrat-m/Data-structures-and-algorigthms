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
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>();
            linkedList.AddLast(30);
            linkedList.AddLast(20);
            linkedList.AddLast(10);
            linkedList.Print();
            
            Node<int> node = linkedList.GetKthNode(4);
            Console.WriteLine(node.Value);
            #endregion

            Console.ReadLine();
        }
    }
}
