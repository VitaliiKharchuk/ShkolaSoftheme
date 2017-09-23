using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {    
        public T data { get; set; }
        public Node <T> prev { get; set; }
        public Node <T> next { get; set; }

        public Node (T  _data)
        {
            data = _data;
            prev = next = null;
        }  
    }
}
