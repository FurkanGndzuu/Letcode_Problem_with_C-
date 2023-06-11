using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Window_Maximum
{
    public class Solution
    {

        IList<int> list = new List<int>();
        IList<int> list2 = new List<int>();
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length <= k)
            {
                int[] response = { nums.Max() };
                return response;
            }
            else
            {
                for(int i = 0; i < nums.Length - k + 1; i++)
                {
                    for(int j = k - 1 + i; j >= 0 + i; j--)
                    {
                        list2.Add(nums[j]);
                    }
                    list.Add(list2.Max());
                    list2.Clear();
                }

                int lengths = list.Count;
                int[] res = new int[lengths];

                for(int i = 0; i < lengths; i++)
                {
                    res[i] = list[i];
                }
                list.Clear();
                return res;
            }
            
        }

    }
}
