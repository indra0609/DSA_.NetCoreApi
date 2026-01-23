using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.String
{
    public class EasyString
    {
        #region ReverseString
        public string ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
            return new string(s);
        }

        #endregion

        #region reverse-vowels-of-a-string
        /*
         * Input: s = "IceCreAm"
           Output: "AceCreIm"
         */
        public string ReverseVowels(string s)
        {
            int i = 0, j = s.Length - 1;
            char[] ch = s.ToCharArray();
            while (i <= j)
            {
                if (isVoweles(ch[i]) && isVoweles(ch[j]))
                {
                    char temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                    i++;
                    j--;
                }
                else if (!isVoweles(ch[i]))
                    i++;
                else
                    j--;

            }
            return new string(ch);
        }
        bool isVoweles(char c)
        {
            if (char.ToUpper(c) == 'A'
            || char.ToUpper(c) == 'E'
            || char.ToUpper(c) == 'I'
            || char.ToUpper(c) == 'O'
            || char.ToUpper(c) == 'U')
                return true;
            return false;
        }
        #endregion

        #region valid-anagram
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> dc = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dc.ContainsKey(s[i])) dc[s[i]]++;
                else dc[s[i]] = 1;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dc.ContainsKey(t[i])) dc[t[i]]--;
                else return false;
            }
            foreach (int value in dc.Values)
            {
                if (value != 0) return false;
            }
            return true;
        }
        #endregion

        #region first-unique-character-in-a-string
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dc = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dc.ContainsKey(s[i])) dc[s[i]]++;
                else dc[s[i]] = 1;
            }
            for (int i = 0; i < s.Length; i++)
                if (dc[s[i]] == 1) return i;
            return -1;
        }
        #endregion
    }
}
