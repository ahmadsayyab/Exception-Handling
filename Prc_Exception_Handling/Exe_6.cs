using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_6
    {
        //6. Write a C# program that reads a string
        //from the user and converts it to an integer.
        //Handle the exception if the input cannot be parsed into an integer.

        public static void StringToInt()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            try
            {
                int conVal = int.Parse(input);
                //int conVal = Convert.ToInt32(input);
                Console.WriteLine($"Your int: {conVal}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input isn't in proper format");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

        }
    }
}
