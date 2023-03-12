using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    public static class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                nums[i] = nums1[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                nums[nums1.Length + i] = nums2[i];
            }

            Array.Sort(nums);

            int a = nums.Length / 2;

            if (nums.Length % 2 == 0)
                return (double)(nums[a] + nums[a - 1]) / 2;
            else return nums[a];
                
            }
        }
}
