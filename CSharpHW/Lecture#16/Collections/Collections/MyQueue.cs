using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class MyQueue<T>
    {

        private int front;
        private int tail;
        private int actualSize;
        private  int capacity;
        private  List<T>list;

        public  MyQueue(int _capacity)
        { 
            front = actualSize = 0;
            tail = capacity - 1;
            capacity = _capacity;

            list = new List<T>(capacity);
            list.AddRange(Enumerable.Repeat(default(T), capacity));
        }
        
        public bool IsFull(MyQueue <T>  queue)
        {
            return queue.actualSize == queue.capacity;
        }

        public bool IsEmpty(MyQueue<T> queue)
        {
            return queue.actualSize == 0;
        }

        public  void  Enqueue(T  item)
        {
            if (IsFull(this))
            {

                Console.WriteLine("Queue   is   full!");
                return;
            }

            
            tail = (tail + 1) % capacity;
         
            list[tail] = item; 
            actualSize++;
        }


        public T  Dequeue()
        {
            if  (IsEmpty(this))
            {
                Console.WriteLine("Queue  is    empty");
                return default(T);
            }

            T item = list[front];
            front = (front + 1) % capacity;

            actualSize--;
            return item;

        }

        public T Peek ()
        {
            if (IsEmpty(this))
            {
                Console.WriteLine("Queue  is    empty");
                return default(T);
            }

            return list[front];
        }    
    }
}
