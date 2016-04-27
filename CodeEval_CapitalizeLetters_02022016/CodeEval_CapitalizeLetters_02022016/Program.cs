using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_CapitalizeLetters_02022016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1st thing";
            string[] words = line.Split();
            StringBuilder capitalWord = new StringBuilder();

            foreach (string word in words)
            {
                char[] wordLetters = word.ToCharArray();
                string upperLetter = wordLetters[0].ToString().ToUpper();
                capitalWord.Append(upperLetter);
                for (int i = 1; i < wordLetters.Length; i ++)
                {
                    capitalWord.Append(wordLetters[i]);
                }
                capitalWord.Append(" ");
            }
            Console.WriteLine(capitalWord.ToString());
        }
    }
}
