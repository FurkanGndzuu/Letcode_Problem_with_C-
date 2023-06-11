using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    public class Solution
    {
        IList<int> list = new List<int>();
        IList<int> zeroes = new List<int>();
        public void MoveZeroes(int[] nums)
        {
            foreach (int i in nums)
            {
                if(i.Equals(0))
                    zeroes.Add(i);
                else
                    list.Add(i);
            }
            for(int i =0; i < list.Count; i++)
                nums[i] = list[i];
            for(int i =0; i <zeroes.Count; i++)
                nums[list.Count + i] = zeroes[i];
            list.Clear();zeroes.Clear();
        }

    }
}
