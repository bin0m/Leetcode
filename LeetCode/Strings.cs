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

        // Longest Substring Without Repeating Characters 
        // time: O(n)
        // space: O(256)
        public static int LengthOfLongestSubstring(string str)
        {
            int n = str.Length;

            // length of current substring
            int currentLength = 1;

            // result
            int maxLength = 1;

            // previous index

            int i;
            int[] visited = new int[256];

            /* Initialize the visited array as -1, -1 is 
            used to indicate that character has not been 
            visited yet. */
            for (i = 0; i < 256; i++)
            {
                visited[i] = -1;
            }

            /* Mark first character as visited by storing the
                index of first character in visited array. */
            visited[str[0]] = 0;

            /* Start from the second character. First character is
            already processed (cur_len and max_len are initialized
            as 1, and visited[str[0]] is set */
            for (i = 1; i < n; i++)
            {
                var prevIndex = visited[str[i]];

                /* If the current character is not present in
                the already processed substring or it is not
                part of the current Substring, then do cur_len++ */
                if (prevIndex == -1 || i - currentLength > prevIndex)
                    currentLength++;

                /* If the current character is present in currently
                considered Substring, then update Substring to start from
                the next character of previous instance. */
                else
                {
                    /* Also, when we are changing the Substring, we
                    should also check whether length of the
                    previous Substring was greater than max_len or
                    not.*/
                    if (currentLength > maxLength)
                        maxLength = currentLength;

                    currentLength = i - prevIndex;
                }

                // update the index of current character
                visited[str[i]] = i;
            }

            // Compare the length of last Substring with max_len and
            // update max_len if needed
            if (currentLength > maxLength)
                maxLength = currentLength;

            return maxLength;
        }

        // Roman to Integer
        // O(n)
        public static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int n = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        n++;
                        break;
                    case 'V':
                        if (i > 0 && s[i - 1] == 'I')
                        {
                            n += 4;
                            i--;
                        }
                        else
                        {
                            n += 5;
                        }
                        break;
                    case 'X':
                        if (i > 0 && s[i - 1] == 'I')
                        {
                            n += 9;
                            i--;
                        }
                        else
                        {
                            n += 10;
                        }
                        break;
                    case 'L':
                        if (i > 0 && s[i - 1] == 'X')
                        {
                            n += 40;
                            i--;
                        }
                        else
                        {
                            n += 50;
                        }
                        break;
                    case 'C':
                        if (i > 0 && s[i - 1] == 'X')
                        {
                            n += 90;
                            i--;
                        }
                        else
                        {
                            n += 100;
                        }
                        break;
                    case 'D':
                        if (i > 0 && s[i - 1] == 'C')
                        {
                            n += 400;
                            i--;
                        }
                        else
                        {
                            n += 500;
                        }
                        break;
                    case 'M':
                        if (i > 0 && s[i - 1] == 'C')
                        {
                            n += 900;
                            i--;
                        }
                        else
                        {
                            n += 1000;
                        }
                        break;
                }
            }
            return n;
        }

        // Longest Palindromic Substring
        // time: O(n^2 )
        // space: O(n^2 )
        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            if(len <= 1)
            {
                return s;
            }

            bool[,] table = new bool[len, len];
            table[len - 1, len - 1] = true;
            int startOfMax = 0;
            int max = 0;
            for (int i = len - 2; i >= 0; i--)
            {
                for(int j = i; j < len; j++)
                {
                    if( i == j )
                    {
                        table[i, j] = true;
                    }
                    else if (i == j - 1)
                    {
                        table[i, j] = s[i] == s[j];
                    }
                    else
                    {
                        table[i, j] = table[i + 1, j - 1] && s[i] == s[j];     
                    }

                    if (table[i, j] && max < j - i + 1)
                    {
                        max = j - i + 1;
                        startOfMax = i;
                    }
                }
            }

            return s.Substring(startOfMax, max);            
        }

    }
}
