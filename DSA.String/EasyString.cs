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
    }
}
