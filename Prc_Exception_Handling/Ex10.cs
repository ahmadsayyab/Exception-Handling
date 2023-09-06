using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_10
    {
        //10. Write a C# program that reads a number from the user
        //and calculates its square root. Handle the exception if the number is negative.


        public static void CallingMethod()
        {
            try
            {
                Console.WriteLine("Enter a number to calculate its square root");
                int num = int.Parse(Console.ReadLine());
                InputCheck(num);

                double sqrtNum = Math.Sqrt(num);
                Console.WriteLine(sqrtNum);

            }
            catch (NegativeValueException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input cannot be a string");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }

        public static void InputCheck(int num)
        {

            if (num < 0)
            {
                throw new NegativeValueException("Number cannot be negative");
            }


        }
    }
}
class NegativeValueException : Exception
{
    public NegativeValueException(string message) : base(message) { }
}
