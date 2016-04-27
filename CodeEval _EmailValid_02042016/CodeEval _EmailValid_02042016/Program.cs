using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeEval__EmailValid_02042016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "good123@bad.com";
            if (Regex.IsMatch(line,@"\w+@\w+.\com"))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }

    }
}
