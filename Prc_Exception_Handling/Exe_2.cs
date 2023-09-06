using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_2
    {
        // Write a C# program to implement a method that takes an
        // integer as input and throws an exception if the number is negative.
        // Handle the exception in the calling code.



       
        public static void CallingMethod()
        {

            try
            {
                Console.WriteLine("Enter an int value");
                int num = int.Parse(Console.ReadLine());
                InputMethod(num);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Cannot input string.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void InputMethod(int num)
        {
            if (num < 0)
            {
                throw new Exception("number cannot be negative");
            }
            else
            {
                Console.WriteLine($"Valid input {num}");
            }
        }


    }
}
