using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgorithms.DataStructures.Interfaces
{
    public interface ILinkedList<T>
    {
        void AddFirst(T value);
        void AddLast(T value);
        void DeleteFirst();
        void DeleteLast();
        bool Contains(T value);
        int IndexOf(T value);

        void Print();
    }
}
