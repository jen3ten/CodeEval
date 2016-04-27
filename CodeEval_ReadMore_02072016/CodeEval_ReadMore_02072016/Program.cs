using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_ReadMore_02072016
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the line is longer than 55 characters,
            //split the line at the spaces and build the string back up with full words but
            //no more than 40 characters.  Add "... <Read More>" to the end of the string.
            //If the line is less than or equal to 55 characters, print it as is.

            //string line = "Amy Lawrence was proud and glad, and she tried to make Tom see it in her face - but he wouldn't look.";
            //string line = "Tom exhibited.";
            //string line = "Tom was tugging at a button-hole and looking sheepish.";
            //string line = "Two thousand verses is a great many - very, very great many.";
            //string line = "Tom's mouth watered for the apple, but he stuck to his work.";
            string line = "123456789A123456789B123456789C123456789D123456789E123456789F123456789G";

            int checkLength = line.Length;
            if (checkLength <= 55)      //If the length of the string is 55 chars or less, print the line as-is
            {
                Console.WriteLine(line);
            }
            else        //else if the length of the string is longer than 55 chars...
            {
                int spaceIndex = line.LastIndexOf(" ", 39);     //Look for the last space within the first 40 chars
                if (spaceIndex < 0)     //If there are no spaces within the first 40 characters of the string
                {
                    string lineSubStr = line.Substring(0, 40) + "... <Read More>";  //Print the 40 char substring and <Read More>
                    Console.WriteLine(lineSubStr);
                }
                else        //Create substring to the index that preceeds the space, which has a length of the last index of the space
                {
                    string lineSubStr = line.Substring(0, spaceIndex) + "... <Read More>";
                    Console.WriteLine(lineSubStr);
                }
            }

        }
    }
}
