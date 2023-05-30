using System;
using System.Collections;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        Size(input);
        SplitSentence(input);
     
    }
    public static int CountLength(string input)
    {
        int length = 0;
        bool isWord = false;
        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c))
            {
                isWord = false;
            }
            else if (!isWord)
            {
                length++;
                isWord = true;
            }
        }
        return length;
    }
    public static void Size(string input)
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
        if (wordBuilder.Length > 0)
        {
            sentence[sentence.Length - 1] = wordBuilder.ToString();
        }
        Console.WriteLine("Массив слов:");
        foreach (string words in sentence)
        {
            Console.WriteLine(words);
        }
    }

    public static void SplitSentence(string input)
    {
        Console.WriteLine("Second method ....................");
     
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
                    Console.WriteLine(word);
                    word = "";
                }
            }
        }
        Console.WriteLine(word);
    }
}
