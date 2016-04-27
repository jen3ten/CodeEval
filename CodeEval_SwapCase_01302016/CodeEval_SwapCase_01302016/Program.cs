using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_SwapCase_01302016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "A letter";
            string lineUpper = line.ToUpper();
            string lineLower = line.ToLower();
            char[] lineArray = line.ToCharArray();
            char[] lineUpperArray = lineUpper.ToCharArray();
            char[] lineLowerArray = lineLower.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lineArray[i] == lineUpperArray[i])
                    lineArray[i] = lineLowerArray[i];
                else
                    lineArray[i] = lineUpperArray[i];
            }
            foreach (char letter in lineArray)
                Console.Write(letter);
            Console.WriteLine();
        }
    }
}
