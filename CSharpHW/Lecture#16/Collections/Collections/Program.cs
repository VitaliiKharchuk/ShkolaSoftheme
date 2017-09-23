using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MyStack<string> myStack1 = new MyStack<string>(40);
            myStack1.pop();
            myStack1.push("sddfsf");
            myStack1.push("qweqwe");
            myStack1.push("fhgfh");
            myStack1.push("123123");

            myStack1.pop();



            MyStack<double> myStack2 = new MyStack<double>(40);
            myStack2.push(4.5);
            myStack2.push(-45.5);
            myStack2.push(2345.5);
            */

            /*
            MyQueue<string> myQueue1 = new MyQueue<string>(45);
            myQueue1.Enqueue("qwerty");
            myQueue1.Enqueue("zxcsdf");

            myQueue1.Dequeue();

            Console.WriteLine(myQueue1.Peek());
            */


            /*        
            MyQueue<int> myQueue = new MyQueue<int>(2);

            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);

            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            */



          
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "sdf");
            myDictionary.Add(2, "234234");
            myDictionary.Add(45, "234234");


            myDictionary[1] = "1223";
            myDictionary[78] = "qwerty";


            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary[5]);
            Console.WriteLine(myDictionary[78]);





            Console.ReadKey();


        }
    }
}
