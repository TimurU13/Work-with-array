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
        List<string> words = splitSentence.SplitSentenceMethod1(input, separateSymbols);
        if (words == null || words.Count == 0)
        {
        Console.WriteLine("Empty input");
        }
        else
        {
            foreach (string word in words)
                {
                   Console.WriteLine(word);
                }
        }
        //Method2...........................................................
        Array wordsSecondMethod = splitSentence.SplitSentenceMethod2(input);
        if (wordsSecondMethod == null)
        {
            Console.WriteLine("Empty input");
        }
        else
        {
            foreach (string word in wordsSecondMethod)
            {
                Console.WriteLine(word);
            }      
        }
    }
}