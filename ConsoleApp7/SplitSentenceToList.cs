using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class SplitSentenceToList
    {
        public List<string> SplitSentenceMethod1(string input, char[] separateSymbols)
        {
            if (string.IsNullOrEmpty(input) || separateSymbols == null)
            {
                return null;
            }
            List<string> words = new List<string>();
            StringBuilder wordBuilder = new StringBuilder();
            foreach (char symbol in input)
            {
                bool isLetter = true;
                foreach (char separateSymbol in separateSymbols)
                {
                    if (symbol == separateSymbol)
                        isLetter = false;
                }
                if (isLetter)
                {
                    wordBuilder.Append(symbol);
                }
                else if (wordBuilder.Length > 0)
                {
                    words.Add(wordBuilder.ToString());
                    wordBuilder.Clear();
                }

            }
            if (wordBuilder.Length > 0)
            {
                words.Add(wordBuilder.ToString());
                wordBuilder.Clear();
            }
            return words;
        }   
    }
}