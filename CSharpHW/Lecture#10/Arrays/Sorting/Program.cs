using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Size of  unsorted  array = ");
            int size;
            Int32.TryParse( Console.ReadLine(),out size);

            MyArray arr = new MyArray(size);

            Console.WriteLine("Unsorted array");
            arr.WriteArray();

            Console.WriteLine("Sorted array");
            MergeSorting.MergeSort(arr.getArray(), 0 ,  size - 1);

            arr.WriteArray();

            Console.ReadKey();

        }
    }
}
