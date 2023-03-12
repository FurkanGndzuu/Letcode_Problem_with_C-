using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //This codes for test

            Random random = new Random();
            int[] array1 = new int[random.Next(1, 5)];
            int[] array2 = new int[random.Next(1, 5)];

            for(int i =0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1,100);
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(1, 100);
                Console.Write(array2[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine(Solution.FindMedianSortedArrays(array1, array2));
            Console.ReadLine();

        }
    }
}
