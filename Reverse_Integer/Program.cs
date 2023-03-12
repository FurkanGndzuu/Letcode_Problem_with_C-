using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //This Codes for Test

            Random random = new Random();

            int a = random.Next(1, 10000);

            if(random.Next(0,2) == 1)
            {
                a *= (-1);
            }

            Console.WriteLine(a);
            Console.WriteLine(Solution.Reverse(a));
            Console.ReadLine();
        }
    }
}
