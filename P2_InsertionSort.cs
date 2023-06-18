using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND9_AlgorithmProblems
{
    internal class P2_InsertionSort
    {
        public static void InsertionSort(int[] array)
        {
            for (int index = 1; index < array.Length; ++index)
            {
                int key = array[index];
                int index2 = index - 1;
                while ((index2 > -1) && array[index2] > key)
                {
                    array[index2 + 1] = array[index2];
                    index2--;
                }
                array[index2 + 1] = key;
            }
            Console.WriteLine();
            Console.WriteLine("The elements in the array after performing Insertion Sort: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
