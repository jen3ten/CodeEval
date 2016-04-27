using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Chardonnay_03072016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Shiraz Grenache | o";
            string[] splitLine = line.Split('|');
            string[] wines = splitLine[0].Split(' ');
            string lettersInWine = splitLine[1].Trim();
            char[] letterChars = lettersInWine.ToCharArray();
            List<string> success = new List<string>();
            for (int i = 0; i < wines.Length; i++)
            {
                bool found = true;
                string wineName = wines[i];
                foreach (char c in letterChars)
                {
                    int index = wines[i].ToLower().IndexOf(c);
                    if (index == -1)
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        wines[i] = wines[i].Remove(index, 1);
                    }
                }
                if (found)
                {
                    success.Add(wineName);
                }
            }
            if (success.Count == 0)
                Console.WriteLine("False");
            else
            {
                foreach (string wine in success)
                {
                    Console.Write(wine);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
