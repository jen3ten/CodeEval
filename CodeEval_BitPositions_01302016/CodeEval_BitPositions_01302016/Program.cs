using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_BitPositions_01302016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "86,2,3";
            string[] splitLine = line.Split(',');
            //determine bits of number in index 0
            //compare bits in position of index 1 and 2
            int num = int.Parse(splitLine[0]);
            int p1 = int.Parse(splitLine[1]);
            int p2 = int.Parse(splitLine[2]);
            string numByte = Convert.ToString(num, 2);
            int len = numByte.Length;
            //Console.WriteLine(numByte);
            //Console.WriteLine(numByte[len - p1]);
            //Console.WriteLine(numByte[len - p2]);
            if (numByte[len-p1] == numByte[len-p2])
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }
    }
}
