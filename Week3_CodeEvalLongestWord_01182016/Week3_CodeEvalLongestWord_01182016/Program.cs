using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_CodeEvalLongestWord_01182016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "lots of words of different lengths";
            string[] splitLine = line.Split(new char[] {' '});
            string longestWord = "";
            for(int counter = 0; counter < splitLine.Length; counter++)
            {
                if (splitLine[counter].Length > longestWord.Length)
                {
                    longestWord = splitLine[counter];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
