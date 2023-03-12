using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    public static class Solution
    {
        public static int Reverse(int x)
        {
            string b="" , a = x.ToString();

            bool Is_There_Any_Minus = false;

            for(int i = a.Length - 1; i >=0 ; i--)
            {
                if (a[i] == '-')
                {
                    Is_There_Any_Minus=true;
                    continue;
                }
                b += a[i];
            }

            if(Is_There_Any_Minus)
                return (Convert.ToInt32(b) * (-1));
            else return Convert.ToInt32(b);
        }
    }
}
