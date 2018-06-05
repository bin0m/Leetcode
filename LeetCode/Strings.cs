using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Strings
    {
        public static string ReverseString(string s)
        {
            //var res = new char[s.Length];
            //for (var i = 0; i < s.Length; i++)
            //    res[i] = s[s.Length - 1 - i];
            //return new string(res);

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int Reverse(int x)
        {
            bool isNegative = false;
            if (x < 0)
            {
                if (x == int.MinValue)
                {
                    return 0;
                }
                x = x * (-1);
                isNegative = true;
            }
            var ch = x.ToString().ToCharArray();
            Array.Reverse(ch);
            try
            {
                var ans = Convert.ToInt32(new String(ch));

                if (isNegative)
                {
                    ans *= (-1);
                }
                return ans;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

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

        public static bool IsAnagram(string s, string t)
        {
            //edge conditions
            if ((s == null && t == null) || (s.Length == 0 && t.Length == 0))
            {
                return true;
            }
            if (s.Length != t.Length)
            {
                return false;
            }

            var charCount = new int[128];
            foreach (char c in s)
            {
                charCount[(int)c]++;
            }
            foreach (char c in t)
            {
                charCount[(int)c]--;
            }
            foreach (int n in charCount)
            {
                if (n != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(string s)
        {
            //edge conditions
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }

            int len = s.Length;
            int head = 0;
            int tail = len - 1;
            while (head < tail)
            {
                if (!char.IsLetterOrDigit(s[head]))
                {
                    head++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[tail]))
                {
                    tail--;
                    continue;
                }
                if (char.ToLower(s[head]) != char.ToLower(s[tail]))
                {
                    return false;
                }
                head++;
                tail--;
            }
            return true;
        }

        public static bool IsPalindrome(int x)
        {
            // edge cases, x is not palindrome when:
            // - negative number
            // - or last digit is 0 (but not when x==0 )
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            //Solution A: using string
            //string str = x.ToString();
            //int head = 0;
            //int tail = str.Length - 1;
            //while (head < tail)
            //{
            //    if (str[head] != str[tail])
            //    {
            //        return false;
            //    }
            //    head++;
            //    tail--;
            //}
            //return true;

            //Solution B: using Math
            if (x < 0)
            {
                return false;
            }
            int reverseNum = 0;
            int n = x;
            while (n > reverseNum)
            {
                int lastDigit = n % 10;
                reverseNum = reverseNum * 10 + lastDigit;
                n = (int)(n / 10);
            }
            return n == reverseNum || n == reverseNum / 10;
        }

        public static int MyAtoi(string str)
        {
            int len = str.Length;
            int i = 0;
            while (i < len && str[i] == ' ')
            {
                i++;
            }

            if (i == len)
            {
                return 0;
            }

            bool isNegative = false;
            if (str[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (str[i] == '+')
            {
                i++;
            }
            int start = i;

            while (i < len && str[i] >= '0' && str[i] <= '9')
            {
                i++;
            }

            if (start == i)
            {
                return 0;
            }

            int x = 0;

            if (Int32.TryParse(str.Substring(start, i - start), out x))
            {
                return isNegative ? -x : x;
            }
            else
            {
                return isNegative ? Int32.MinValue : Int32.MaxValue;
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string lcp = "";
            if (strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                char ch = strs[0][i];
                foreach (string str in strs)
                {
                    if (str.Length <= i || str[i] != ch)
                    {
                        return lcp;
                    }
                }
                lcp = strs[0].Substring(0, i + 1);
            }
            return lcp;
        }

        public static string CountAndSay(int n)
        {
            String str = "1";
            for (int i = 1; i < n; i++)
            {
                str = CountAndSay(str);
            }
            return str;
        }

        public static string CountAndSay(String input)
        {
            //edge conditions
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            var sb = new StringBuilder();
            char prevCh = input[0];
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == prevCh)
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(prevCh);
                    prevCh = input[i];
                    count = 1;
                }
            }
            sb.Append(count);
            sb.Append(prevCh);
            return sb.ToString();
        }
    }
}
