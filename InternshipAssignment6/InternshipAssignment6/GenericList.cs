using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InternshipAssignment6
{
    internal class GenericCollection <Type>
    {
        private readonly Type[] _items;
        private int _currentIndex = -1;
        private readonly int _maxSize;

        public GenericCollection(int maxSize = 10)
        {
            _maxSize = maxSize;
            _items = new Type[maxSize];
        }

        public int Count => _currentIndex + 1;

        public Type GetAtIndex(int index)
        {
            if (index >= _maxSize)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            return _items[index];
        }

        public void SetAtIndex(int index, Type item)
        {
            if (index >= _maxSize)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
           _items[index] = item;
        }

        public void SwapByIndexes(int index1, int index2)
        {
            if (index1 >= _maxSize || index2 >= _maxSize)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            Type helper = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = helper;
        }

        public void SwapByItems(Type item1, Type item2)
        {
            int index1 = -1, index2 = -1;

            for(int i=0; i<_maxSize; i++)
            {
                if (_items[i].Equals(item1))
                {
                    index1 = i;
                }
                else if (_items[i].Equals(item2))
                {
                    index2 = i;
                }
            }

            if(index1 != -1 && index2 != -1)
            {
                SwapByIndexes(index1, index2);
            } 
            else
            {
                Console.WriteLine("The items are not in the list!");
            }
        }

        public void WriteList()
        {
            foreach(Type item in _items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
