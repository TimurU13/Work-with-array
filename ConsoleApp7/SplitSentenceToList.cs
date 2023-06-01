using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class SplitSentenceToList
    {
        public List<string> SplitSentence(string input, char[] separateSymbols)
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
            //Дополнительное условие if (wordBuilder.Length > 0),оно необходимо для записи последнего слова.
            //Так как в случае если последний символ нашей получаемой строки НЕ разделитель,то последнее слово не будет добавлено в наш список.
            //Потому что при обработки нашего последнего символа мы даже не зайдем в else if.
            if (wordBuilder.Length > 0)
            {
                words.Add(wordBuilder.ToString());
                wordBuilder.Clear();
            }
            return words;
        }
        public List<string> SplitSentenceMethod2(string input, char[] separateSymbols)
        {
            Console.WriteLine("Second method......................");
            if (string.IsNullOrEmpty(input) || separateSymbols == null)
            {
                return null;
            }
            List<string> words = new List<string>();
            StringBuilder wordBuilder = new StringBuilder();
            foreach (char symbol in input)
            {
                if (!separateSymbols.Contains(symbol))
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