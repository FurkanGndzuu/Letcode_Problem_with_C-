using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This Codes are for tests

            Random random = new Random();

            int[] array = new int[10];

            for(int i = 0; i< array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.Write(array[i] + " ");
            }

            int target = array[random.Next(10)] + array[random.Next(10)];

            Console.WriteLine(target);


            int[] answer = new int[2];

            answer = TwoSumProblem.answer(array, target);


            Console.WriteLine(answer[0] + " " + answer[1]);

            Console.ReadLine();
        }
    }
}
