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
        public Array SplitSentenceMethod2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            int length = CountLength(input);
            string[] words = new string[length];
            StringBuilder wordBuilder = new StringBuilder();
            int index = 0;
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    wordBuilder.Append(c);
                }
                else if (wordBuilder.Length > 0)
                {
                    {
                        words[index] = wordBuilder.ToString();
                        wordBuilder.Clear();
                        index++;
                    }
                }
            }
            if (wordBuilder.Length > 0)//Для последнего слова
                                       //Так как последний вход у него происходит в if и он создает слово и не записывает его
            {
                words[words.Length - 1] = wordBuilder.ToString();
                wordBuilder.Clear();
            }
            Console.WriteLine("Second method.................");
            return words;

        }
        public int CountLength(string input)//Метод который считает размер строки,для того чтобы в будущем создать массив такого размера
        {
            int length = 0;
            bool isWord = false;//Изначально установлен на false
            {

                foreach (char c in input)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        isWord = false;
                    }
                    else if (!isWord)
                    {
                        length++;
                        isWord = true;//При получение первого символа слова увеличивает счетчик на один
                                      //И устанавливает isWord в 
                                      //Чтобы до момента пока мы не получим пробел счетчик не считал каждый символ одного слова,за новое слово.
                    }
                }
            }
            return length;
        }
        public List<String> SplitSentenceMethod3(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            Console.WriteLine("Third method ....................");
            List<string> words = new List<string>();
            string word = "";
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    word += c;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(word))
                    {
                        words.Add(word);
                        word = "";
                    }   
                }
            }
            return words;
        }
    }
}