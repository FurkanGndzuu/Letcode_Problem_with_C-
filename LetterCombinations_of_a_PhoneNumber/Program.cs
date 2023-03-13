using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations_of_a_PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This codes for test

            Random random = new Random();
            string a = "";

            for(int i =0; i <random.Next(0,4); i++)
            {
                a+=random.Next(2,10);
            }
            Console.Write(a);

            Console.WriteLine();

            IList<string> list = Solution.answer(a);

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();


        }
    }
}
