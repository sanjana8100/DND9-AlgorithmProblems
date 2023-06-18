using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND9_AlgorithmProblems
{
    internal class P3_BubbleSort
    {
        public static void Bubblesort(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                for (int index2 = index + 1; index2 < array.Length; index2++)
                {
                    if (array[index] > array[index2])
                    {
                        int temp = array[index];
                        array[index] = array[index2];
                        array[index2] = temp;
                    }
                }
            }
            Console.WriteLine("The Elements in the Array after performing Bubble Sort: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
