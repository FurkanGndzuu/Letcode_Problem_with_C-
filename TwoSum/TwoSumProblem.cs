using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public static class TwoSumProblem
    {

        public static int[] answer(int[] nums , int target)
        {
            int[] array = new int[2];
            int i = 0;
           

            while(i < nums.Length)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                 
                    if(nums[i] + nums[j] == target)
                    {
                        array[0] = i;
                        array[1] = j;
                        break;
                    }
                }
                i++;
            }

            return array;

        }

    }
}
