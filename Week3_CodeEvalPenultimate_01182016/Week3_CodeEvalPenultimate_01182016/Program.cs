using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_CodeEvalPenultimate_01182016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "some line with text";
            string[] splitLine = line.Split(new char[] {' '});
            Console.WriteLine(splitLine[splitLine.Length - 2]);

        }
    }
}
