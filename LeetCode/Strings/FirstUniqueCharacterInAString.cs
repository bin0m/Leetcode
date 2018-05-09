using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class FirstUniqueCharacterInAString
    {
        public static int FirstUniqChar(string s)
        {
            int size = s.Length;
            if (size == 1)
            {
                return 0;
            }
            var charCount = new int[128];
            foreach (char c in s)
            {
                charCount[(int)c]++;
            }

            for (int i = 0; i < size; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            //NotFound
            return -1;

            //int size = s.Length;
            //if (size == 1)
            //{
            //    return 0;
            //}
            //var once = new Dictionary<int, int>();
            //var oncePostions = new HashSet<int>();
            //var more = new HashSet<int>();
            //for (int i = 0; i < size; i++)
            //{
            //    int curr = s[i];
            //    if (!more.Contains(curr))
            //    {
            //        if (!once.ContainsKey(curr))
            //        {
            //            once.Add(curr, i);
            //            oncePostions.Add(i);
            //        }
            //        else
            //        {
            //            oncePostions.Remove(once[curr]);
            //            once.Remove(curr);
            //            more.Add(curr);
            //        }
            //    }
            //}
            //if (oncePostions.Count == 0)
            //{
            //    return -1;
            //}

            //return oncePostions.Min();
        }
    }
}
