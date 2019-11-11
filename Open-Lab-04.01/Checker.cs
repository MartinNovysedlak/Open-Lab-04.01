using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            for (var j = 0; j < str.Length - 1; j++)
                if (str[j] == str[j + 1])
                {
                    return true;
                }
            return false;
        }
    }
}
