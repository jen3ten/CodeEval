using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_NModM_02142016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "2,3";
            string[] lineSplit = line.Split(',');
            int N = int.Parse(lineSplit[0]);
            int M = int.Parse(lineSplit[1]);
            int intQ = N / M;
            int mod = N - (M * intQ);
            Console.WriteLine(mod);
        }
    }
}
