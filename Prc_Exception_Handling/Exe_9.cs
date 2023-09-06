using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_9
    {
        //9. Write a C# program that creates a method
        //that reads a date from the user in the format "dd/mm/yyyy"
        //and converts it to a DateTime object. Handle an exception if the input format is invalid.

        public static void InputCheck()
        {


            //Was Stuck in it, following logic is from exercise solution.
            try
            {
                Console.Write("Input a date (format-> dd/mm/yyyy): ");
                string input = Console.ReadLine();

                DateTime date = ConvertToDate(input);

                Console.WriteLine("Date: " + date.ToShortDateString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid date format. Please input a valid date in the format dd/mm/yyyy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static DateTime ConvertToDate(string input)
        {
            string[] format = {
      "dd/MM/yyyy"
    };
            return DateTime.ParseExact(input, format, null, System.Globalization.DateTimeStyles.None);
        }
    }
}
