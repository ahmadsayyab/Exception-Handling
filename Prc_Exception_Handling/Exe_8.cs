using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_8
    {
        //8. Write a C# program that implements a method that divides two numbers.
        //Handle the DivideByZeroException that occurs if the denominator is 0.

        public static void DiviByZeroExcep()
        {



            try
            {
                Console.WriteLine("Enter num1");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter num2");
                int num2 = int.Parse(Console.ReadLine());



                int result = num1 / num2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

    }
}