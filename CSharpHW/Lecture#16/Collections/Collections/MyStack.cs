using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    public class MyStack<T>
    {
        static readonly int defaultSize = 15;

        private T[] _items = null;

        private int _currentIndex = 0;

        public MyStack() : this(defaultSize) { }

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void push(T item)
        {
            if (_currentIndex >= _items.Length)
            {
                Console.WriteLine("Stack    overfloved");
            }

            else
            {
                _items[_currentIndex] = item;
                _currentIndex++;
            }
        }

        public T pop()
        {

            if (_currentIndex <= 0) //{ throw new Exception("Stack underfloved"); }
            {

                Console.WriteLine("Stack  underflowed");
                return default(T);
            }

            _currentIndex--; 
            return _items[_currentIndex];
        }

    }
}
