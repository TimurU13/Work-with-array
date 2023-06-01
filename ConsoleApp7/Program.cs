using ConsoleApp7;
using System;
using System.Collections;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        char[] separateSymbols = { ' ', ',', ':', ';', '.' };
        SplitSentenceToList splitSentence = new SplitSentenceToList();
        List<string> ListWords = splitSentence.SplitSentence(input, separateSymbols);
        if (ListWords == null || ListWords.Count == 0)
        {
            Console.WriteLine("Empty input");
        }
        else
        {
            foreach (string word in ListWords)
            {
                Console.WriteLine(word);
            }
        }
        //Method 2...................................
        List<string> ListWordsSecondMethod = splitSentence.SplitSentenceMethod2(input, separateSymbols);
        if (ListWordsSecondMethod == null || ListWordsSecondMethod.Count == 0)
        {
            Console.WriteLine("Empty input");
        }
        else
        {
            foreach (string word in ListWordsSecondMethod)
            {
                Console.WriteLine(word);
            }
        }
    }
}