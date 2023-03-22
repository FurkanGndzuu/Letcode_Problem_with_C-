using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations_of_a_PhoneNumber
{
    public static class Solution
    {
        private static Dictionary<char, string> keys = new Dictionary<char, string> {
        {'1',"."},
        {'2',"abc"},
        {'3',"def"},
        {'4',"ghi"},
        {'5',"jkl"},
        {'6',"mno"},
        {'7',"pqrs"},
        {'8',"tuv"},
        {'9',"wxyz"},
        {'0',"_"}
        };
        
        public static IList<string> answer(string digits)
        {
             IList<string> list = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return list;

            Helper(digits, 0, "", list);
            return list;

        }

        private static void Helper(string digits, int index, string temp, IList<string> list)
        {
            if (index == digits.Length)
            {
                list.Add(temp);
                return;
            }
            string letters = keys[digits[index]];
            for (var i = 0; i < letters.Length; i++)
            {
                temp += letters[i];
                Helper(digits, index + 1, temp, list);
                temp = temp.Remove(temp.Length - 1, 1);
            }
        }
    }
}
