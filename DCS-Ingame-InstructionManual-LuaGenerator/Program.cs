using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Ingame_InstructionManual_LuaGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of pages and then press ENTER:");
            
            int numberOfPages = Convert.ToInt32(Console.ReadLine());

            string header =
                "return\n" +
                "{";

            string start =
                "--------------------------------------------------------------\n" +
                "-- PAGE";

            string middle =
                 "\n" +
                 "--------------------------------------------------------------\n" +
                 "{\n" +
                 "{'picture', [[image manual page";

            string end =
                ".png]]}\n" +
                "},";

            string endSpecial =
                ".png]]}\n" +
                "}\n" + 
                "}";

            //spacer so that the user knows were to start to copy
            Console.WriteLine("Your output is below this line. Paste into\n" +
                "`...Saved Games\\DCS.openbeta\\mods\\aircraft\\UH-60L\\Doc\\manual_en\\manual.txt.lua`\n" +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            //write the special header
            Console.WriteLine(header);

            //loop for creatibng the pages
            for (int numberOfTimes = 1; numberOfTimes < numberOfPages + 0; numberOfTimes++)
            {
                Console.WriteLine(start + numberOfTimes + middle + numberOfTimes + end);
            }

            //catch the last line format
            Console.WriteLine(start + numberOfPages + middle + numberOfPages + endSpecial);

            Console.WriteLine("--end");
            //wait till the user does something to close the console
            Console.ReadKey();
        }
    }
}
