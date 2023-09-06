using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_7
    {
        //7. Write a C# program that reads a list of integers from the user.
        //Handle the exception that occurs if the user enters a value outside the range of Int32.

        public static void CallingMethod()
        {

            try
            {
                Console.WriteLine("Enter an integer value OR enter q to quit");
                List<int> list = new List<int>();

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "q")
                    {
                        break;
                    }




                    int number = Convert.ToInt32(input);
                    list.Add(number);

                }


                HandleListExcep(list);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The value entered is outside the range of Int32.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Only int values are allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
        public static void HandleListExcep(List<int> myList)
        {

            foreach (int i in myList)
            {



                Console.Write(i + " ");
            }

            Console.WriteLine("\n");



        }

    }
}



