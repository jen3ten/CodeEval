using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_CodeEvalFindAWriter_01202016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "3Kucdq9bfCEgZGF2nwx8UpzQJyHiOm0hoaYP6ST1WM7Nks5XjrR4IltBeDLV vA| 2 26 33 55 34 50 33 61 44 28 46 32 28 30 3 50 34 61 40 7 1 31";
            string[] splitLine = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries );
            string hiddenName = splitLine[0];
            string key = splitLine[1];
            string[] splitKey = key.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < splitKey.Length; index++)
            {
                int nameIndex = int.Parse(splitKey[index]);
                Console.Write(hiddenName[(nameIndex - 1)]);
            }
        }
    }
}
