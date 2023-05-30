using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class ThirdMethod
    {
        public static int CountLength(string input)//Метод который считает размер строки,для того чтобы в будущем создать массив такого размера
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
        public static void SplitSentence(string input)
        {
            int length = CountLength(input);
            string[] sentence = new string[length];
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
                        sentence[index] = wordBuilder.ToString();
                        wordBuilder.Clear();
                        index++;
                    }
                }
            }
            if (wordBuilder.Length > 0)//Для последнего слова
                                       //Так как последний вход у него происходит в if и он создает слово и не записывает его
            {
                sentence[sentence.Length - 1] = wordBuilder.ToString();
                wordBuilder.Clear();
            }
            Console.WriteLine("Third method.................");
            foreach (string words in sentence)
            {
                Console.WriteLine(words);
            }
        }
    }
}
