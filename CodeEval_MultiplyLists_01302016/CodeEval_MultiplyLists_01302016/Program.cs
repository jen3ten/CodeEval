using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_MultiplyLists_01302016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "9 0 6 | 15 14 9";
            string[] splitLine = line.Split(' ');
            for (int i = 0; i < splitLine.Length / 2; i++)
            {
                int numA = int.Parse(splitLine[i]);
                int numB = int.Parse(splitLine[i + splitLine.Length/2 + 1]);
                Console.Write((numA * numB) + " " );
            }
        }
    }
}
