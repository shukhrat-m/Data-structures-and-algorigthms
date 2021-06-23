using System;

namespace DSandAlgorithms.DataStructures
{
    public class DynamicArray <T>
    {
        private T[] _arr;
        private int _size;
        private int _pointer;

        public DynamicArray (int length)
        {
            _arr = new T[length];
            _pointer = 0;
        }

        public void Insert(T value)
        {
            if (_pointer == _arr.Length)
            {
                T[] arr = new T[_pointer * 2];

                for (int i = 0; i < _pointer; i++)
                {
                    arr[i] = _arr[i];
                }

                _arr = arr;
            }

            _arr[_pointer++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _pointer)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < _pointer; i++)
            {
                _arr[i] = _arr[i + 1];
            }

            _pointer--;
        }

        public new void ToString()
        {
            for (int i = 0; i < _pointer; i++)
            {
                Console.Write(_arr[i]);
            }

            Console.WriteLine();
        }
    }
}
