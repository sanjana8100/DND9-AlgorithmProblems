using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND9_AlgorithmProblems
{
    internal class P1_BinarySearch
    {
        public static void BinarySearch(string[] array, string data)
        {
            Array.Sort(array);

            Console.WriteLine("The elements in the array after sorting: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();

            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid].CompareTo(data) == 0)
                {
                    Console.WriteLine($"{data} is present at position {mid + 1}");
                    return;
                }
                if (array[mid].CompareTo(data) < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine($"{data} not found");
        }
    }
}
