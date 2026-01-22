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
    }
}
