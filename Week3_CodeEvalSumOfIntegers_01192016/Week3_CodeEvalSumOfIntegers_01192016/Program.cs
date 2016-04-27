using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_CodeEvalSumOfIntegers_01192016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "0, 0, 1, -2";
            char[] separators = new char[] { ' ', ',' };
            string[] splitLine = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] numArray = new int[splitLine.Length];
            for (int i = 0; i < splitLine.Length; i++)
            {
                numArray[i] = int.Parse(splitLine[i]);
            }
            int largestSum = int.MinValue;
            int contigSum;
            for(int startIndex = 0; startIndex < numArray.Length; startIndex++)
            {
                contigSum = 0; 
                for(int contigNums = startIndex; contigNums < numArray.Length; contigNums++)
                {
                    contigSum = contigSum + numArray[contigNums];
                    if (contigSum > largestSum)
                    {
                        largestSum = contigSum;
                    }
                }
            }
            Console.WriteLine(largestSum);
        }
    }
}
