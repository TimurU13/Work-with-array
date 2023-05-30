using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class FirstMethod
    {
        public static void SplitSentence(string input)
        {
            string[] words = input.Split(' ');

            Console.WriteLine("First method............");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}


