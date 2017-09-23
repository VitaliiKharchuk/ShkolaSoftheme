using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

     
            MyLinkedList<int> list = new MyLinkedList<int>();  

            list.InsertAfter(11);
            list.InsertFirst(5);
            list.InsertFirst(6);
            list.InsertFirst(7);
            list.InsertAfter(1);
            list.InsertAfter(81);
            list.InsertAfter(10);
            list.InsertAfter(-1);

            list.DeleteFirst();
            list.DeleteAfter();

        
            Node<int> node = list.GetNode(7);

            if (node == null)
                Console.WriteLine("Element is  apsent");
            else 
                 Console.WriteLine("Elemetn  is   present");



            Console.WriteLine("Lenght =  {0}",  list.length);

            


            Console.ReadKey();
        }
    }
}
