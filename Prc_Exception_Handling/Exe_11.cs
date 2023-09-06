using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_11
    {
        //11. Write a C# program that creates a method that takes a string as input
        //and converts it to uppercase.
        //Handle the NullReferenceException that occurs if the input string is null.

        public static void CallingMethod()
        {
            try
            {
                Console.WriteLine("Enter a string");
                string input = Console.ReadLine();

                string result = ConvertStrToUpperCase(input);
                Console.WriteLine(result);



            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input cannot be other than string");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }

        public static string ConvertStrToUpperCase(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                throw new NullReferenceException("String cannot be null");
            }


            return input.ToUpper();

        }
    }
}


