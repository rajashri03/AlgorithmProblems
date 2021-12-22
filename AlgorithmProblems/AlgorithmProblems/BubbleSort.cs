using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    /// <summary>
    /// Program to Implement Bubble Sort
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Method(Bsort) for implementing bubble sort
        /// </summary>
        public void BSort()
        {
            int[] arr = { 78, 43, 22, 67, 90, 34 };//Declare array
            int len = arr.Length;//calculate Length of array
            int i, j, temp;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        //swap temp and arr[i];
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        //prints the array
                        Console.WriteLine("Sorted array:");
                        foreach (int sortdata in arr)
                        {
                            Console.WriteLine(sortdata);
                        }
                    }
                }
            }
        }
    }
}
