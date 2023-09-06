using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_12
    {
        //12. Write a C# program that creates a method that calculates the factorial of a given number.
        //Handle the OverflowException that occurs if the result exceeds the Int32 maximum value.

        public static void CallingMethod()
        {
            try
            {
                Console.WriteLine("Enter a number to calculate its factorial");
                int input = int.Parse(Console.ReadLine());

                int result = CalcFact(input);
                Console.WriteLine(result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The result is outside the range of Int32.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Only positive int values are allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static int CalcFact(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("Input cannot be negative");
            }
            int factVal = 1;
            for (int i = 1; i <= input; i++)
            {
                factVal *= i;
            }
            return factVal;
        }
    }
}
