using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleNonDuplicate
{
    public static class Solution
    {
        public static int SingleNonDuplicate(int[] nums)
        {
            Dictionary<int , int> dic = new Dictionary<int , int>();    

            foreach (int i in nums)
            {
                if (!dic.ContainsKey(i))
                    dic.Add(i, 1);
                else
                {
                   dic.Remove(i);
                    dic.Add(i, 2);
                }
                 
            }
            int response = dic.FirstOrDefault(x => x.Value == 1).Key;
            dic.Clear();
            return response;
        }
    }
}
