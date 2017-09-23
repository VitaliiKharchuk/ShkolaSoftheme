using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class MyLinkedList<T>
    {
        public int length{ get; private set; }

        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }

        public MyLinkedList()
        {
            head = tail = null;
        }

        public  Node<T> InsertFirst(T data)
        {

            var link = new Node<T>(data);

            link.next =  head;
            if (head != null)
                head.prev = link;

            head = link;


            if (length == 0)
            {
                tail = link;
            }

            length++;

            return link;
        }


        public Node<T> InsertAfter(T data)
        {

            var link = new Node<T>(data);

            link.prev = tail;

            if (tail != null)
                tail.next = link;

            tail = link;

            if (length == 0)
            {
                head = link;
            }

            length++;

            return link;
        }


        public  Node<T>  DeleteFirst()
        {

            Node<T> temp =  head;
            if (head != null)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
            }

            else
            {
                Console.WriteLine("Forbidden  operation!  List  is  empty");
            }

            return temp;
        }

        public  Node<T>  DeleteAfter()
        {
            Node<T> temp = tail;

            if (tail!= null)
            {
                tail = tail.prev;
                if (tail != null)
                {
                    tail.next = null;
                }
            }
            else
            {
                Console.WriteLine("Forbidden  operation!  List  is  empty");
            }

            return temp;
        }


        public Node<T> GetNode(T  data)
        {

            Node<T> node = this.head;

            while (node != null)
            {

                if (node.data.Equals(data))
                {
                    return node;
                }


                node = node.next;
            }

            return null;
        }





    }




}
