using System;

namespace LookingForConsecutiveChars
{
    public class ConsecutiveAnalyzer
    {
        public static int GetQuantityOfMaxConsecutiveLetters(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0)
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;
            bool IsAnyLetters = false;
            char[] latinAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char prevChar = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                if (latinAlphabet.Contains(str[i]))
                {
                    IsAnyLetters = true;

                    if (str[i] == prevChar)
                    {
                        currentCount++;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, currentCount);
                        currentCount = 1;
                    }

                    prevChar = str[i];
                }
            }

            if (!IsAnyLetters)
            {
                return 0;
            }
            else
            {
                return Math.Max(maxCount, currentCount);
            }
        }
        public static int GetQuantityOfMaxConsecutiveDigits(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0)
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;
            bool IsAnyDigits = false;
            char prevChar = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    IsAnyDigits = true;

                    if (str[i] == prevChar)
                    {
                        currentCount++;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, currentCount);
                        currentCount = 1;
                    }

                    prevChar = str[i];
                }
            }

            if (!IsAnyDigits)
            {
                return 0;
            }
            else
            {
                return Math.Max(maxCount, currentCount);
            }
        }
    }
}