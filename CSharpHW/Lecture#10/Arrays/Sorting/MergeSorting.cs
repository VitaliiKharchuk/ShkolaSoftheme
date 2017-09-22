using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    static class MergeSorting
    {


        static public void  MergeSort(int []  numbers,  int left, int  right)
        {

            if  (left < right)
            {

                int middle = (left + right) / 2;

                MergeSort(numbers, left, middle);
                MergeSort(numbers, middle + 1, right);

                Merge(numbers,  left,  middle, right);
            }



        }
        
    
        //  l..m   - first  subarray
        // m  + 1 ..r  - second  subarray

        static  private  void  Merge(int []  numbers,  int  left, int   middle, int right)
        {

            int size1 = middle - left + 1;
            int size2 = right - middle;

            int[]  leftSubArray = new int[size1];
            int[] rightSubArray = new int[size2];

            for  (int  i = 0; i <  size1; i++)
            {
                leftSubArray[i] = numbers[left + i];
            }

            for (int i = 0; i < size2; i++)
            {
                rightSubArray[i] = numbers[middle + 1 + i];
            }



            int pointerLeft = 0;
            int pointerRight = 0;
            int pointerBase = left;

            while (pointerLeft < size1 &&  pointerRight < size2)
            {

                if  (leftSubArray[pointerLeft] < rightSubArray[pointerRight])
                {
                    numbers[pointerBase] =  leftSubArray[ pointerLeft];
                    pointerLeft++;
                }

                else
                {
                    numbers[pointerBase] = rightSubArray[pointerRight];
                    pointerRight++;
                }

                pointerBase++;

            }



            while (pointerLeft <  size1)
            {
                numbers[pointerBase] = leftSubArray[pointerLeft];
                pointerLeft++;
                pointerBase++;
            }

            while (pointerRight < size2)
            {
                numbers[pointerBase] = rightSubArray[pointerRight];
                pointerRight++;
                pointerBase++;
            }
        }
    }
}
