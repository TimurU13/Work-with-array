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
        FirstMethod.SplitSentence(input);
        SecondMethod.SplitSentence(input);
        ThirdMethod.SplitSentence(input);
    }
}
