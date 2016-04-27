using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_TimeToEat_02142016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "02:26:31 14:44:45 09:53:27";
            string[] lineSplit = line.Split(' ');
            for (int i = 0; i < lineSplit.Length; i++)
            {
                string lineSplitElement = lineSplit[i];
                lineSplitElement = String.Concat(lineSplitElement[0].ToString(), lineSplitElement[1].ToString(), lineSplitElement[3].ToString(), lineSplitElement[4].ToString(), lineSplitElement[6].ToString(), lineSplitElement[7].ToString());
                lineSplit[i] = lineSplitElement;
            }
            Array.Sort(lineSplit);
            for (int i = lineSplit.Length - 1; i >= 0 ; i--)
            {
                string lineSplitElement = lineSplit[i];
                Console.Write(lineSplitElement[0].ToString() + lineSplitElement[1].ToString() + ":" + lineSplitElement[2].ToString() + lineSplitElement[3].ToString() + ":" + lineSplitElement[4].ToString() + lineSplitElement[5].ToString() + " ");
            }
            Console.WriteLine();

        }
    }
}
