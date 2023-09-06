using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_5
    {
        //5. Write a C# program that implements a method that
        //takes an array of integers as input and calculates the average value.
        //Handle the exception if the array is empty.


        public static void CallingMethod()
        {
            try
            {
                //int[] arr = { 9, 9, 9 };
                //int[] arr = { 33, 99, 17 };
                int[] arr = new int[0];
                CalcAvg(arr);
            }
            catch (EmptyArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Only int values are allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public static void CalcAvg(int[] arr)
        {

            if (arr.Length == 0)
            {
                throw new EmptyArrayException("Array is empty");
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double avg = sum / arr.Length;
            Console.WriteLine(avg);




        }
    }
}
class EmptyArrayException : Exception
{
    public EmptyArrayException(string message) : base(message) { }
}

