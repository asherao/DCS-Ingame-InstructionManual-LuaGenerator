using System;

/* This tool creates an easy way to create the lua for the instruction manual pages.
 * One centered image per page.
 * Remember to add a line like `set_manual_path('<aircraft>', current_mod_path .. '/Doc/manual')` right before
 * the `plugin_done()` line in the aircraft's `<aircraft>\entry.lua` file.
 * An example of a generated file can be found here: https://github.com/asherao/uh-60l/releases/tag/1.0
*/

/* Examples of formatting are below.
-- [color=0xffffffff]
-- [color=0x6090c0ff]
-- •
-- [b]bold[/b]

-- {'header1', [[[color=0xffffffff]Header 1]]},
-- {'header2', [[Header 2]]},
-- {'header3', [[[color=0xffffffff]Header 3]]},

-- {'text', [[
-- Below is a list of essential commands used when flying the UH-1H in Game Avionics Mode:
-- ]]},

-- {'picture', [[image manual page6.png]]}

-- [color=0x6090c0ff]RSHIFT + M[/color]

-- Refer to Huey for a full example
*/

/* Cool things to add:
 * A gui
 * A way to select the module or location to extract the lua file
 * A full tutorial on the Manual system
 * A way to define the image name prefix (eg, image manual page)
 * Ask how many spaces you want at the top, before each image
 * Ask how many images they want per page (ex 1 or 2)
 */

namespace DCS_Ingame_InstructionManual_LuaGenerator
{
    internal class Program
    {
        static void Main(string[] args) // no args[] used
        {
           
            Console.WriteLine("Your output will be below the line. Paste into\n" +
                "`...Saved Games\\DCS.openbeta\\mods\\aircraft\\<YourAircraft>\\Doc\\manual_en\\manual.txt.lua`\n" +
                "Enter the number of pages and then press ENTER:");
            
            //the number if pages the user wanted
            int numberOfPages = Convert.ToInt32(Console.ReadLine());

            //spacer so that the user knows were to start to copy
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            //init strings
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
                 "{'text', [[\n" +
                 " \n" +
                 " \n" +
                 " \n" +
                 " \n" +
                 " \n" +
                 "]]},\n" +
                 "{'picture', [[image manual page";

            string end =
                ".png]]}\n" +
                "},";

            string endSpecial =
                ".png]]}\n" +
                "}\n" + 
                "}";

            //write the special header
            Console.WriteLine(header);

            //loop for creatibng the pages
            for (int numberOfTimes = 1; numberOfTimes < numberOfPages; numberOfTimes++)
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
