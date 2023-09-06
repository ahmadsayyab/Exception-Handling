using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_1
    {
        //1. Write a C# program that prompts
        //the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.

        public static void DiviNumbers()
        {



            try
            {
                Console.WriteLine("Enter num1");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2");
                double num2 = double.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine(result);
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Cannot enter a non numeric  value");
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }

        }

    }
}
