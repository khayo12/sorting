using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SortingEx
{
    public class Sort : ISort
    {
        private readonly string specialCharacters = @"[,.?!-;:'() {}|&%$#@^*+_`~<>/\\]";
        public string SortText(string text)
        {            
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("The text must not be empty.");
                }

                var toSort = Regex.Replace(text.ToLowerInvariant(), specialCharacters, "");
                var sortedText = new StringBuilder();
                var l = toSort.Length;
                var textArray = toSort.ToCharArray(0, l);
                char ch;

                for (int i = 1; i < l; i++)
                {
                    for (int j = 0; j < l - i; j++)
                    {
                        if (textArray[j] > textArray[j + 1])
                        {
                            ch = textArray[j];
                            textArray[j] = textArray[j + 1];
                            textArray[j + 1] = ch;
                        }
                    }
                }

                foreach (char c in textArray)
                {
                    sortedText.Append(c);
                }

                return sortedText.ToString();
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }
    }
}
