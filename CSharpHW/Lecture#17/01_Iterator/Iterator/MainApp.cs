using System;

namespace Iterator
{
    class MainApp
    {
        static void Main()
        {
            ConcreteAggregate<string> a = new ConcreteAggregate<string>();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            
            Console.WriteLine("Iterating over collection of  strings:");

            var iterator1 = new ConcreteIterator<string>(a);

            var item = iterator1.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator1.Next();
            }



            Console.ReadKey();
        }
    }
}