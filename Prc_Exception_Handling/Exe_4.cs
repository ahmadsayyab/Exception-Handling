using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_4
    {
        //4. Write a C# program that prompts
        //the user to input a numeric integer and throws an exception
        //if the number is less than 0 or greater than 1000.

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
            if (num < 0 || num > 1000)
            {
                throw new Exception("Error: number should be in between 0 to 1000");
            }
            else
            {
                Console.WriteLine($"Valid input {num}");
            }
        }

    }
}
