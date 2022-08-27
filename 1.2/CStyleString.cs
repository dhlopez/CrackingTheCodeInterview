using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodeInterviewChapter1._1._2
{
    public class CStyleString
    {
        public string ReverseString(string strToReverse)
        {
            char[] strConvertedToChar = strToReverse.ToCharArray();

            StringBuilder result = new StringBuilder();

            for (int i = strToReverse.Length-1; i >= 0; i--)
            {
                result.Append(strConvertedToChar[i]);
            }

            return result.ToString();
        }
    }
}
