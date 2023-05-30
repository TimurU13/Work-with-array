using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ThirdMethod
    {
        public static void SplitSentence(string input)
        {
            Console.WriteLine("Third method ....................");

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
}
