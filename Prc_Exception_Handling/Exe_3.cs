using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_3
    {
        //3. Write a C# program that reads a file path
        //from the user and tries to open the file. Handle exceptions if the file does not exist.


        //Execise soultion
        public static void filePath()
        {

            Console.Write("Input the file path: ");
            string filePath = Console.ReadLine();
            try
            {

                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("File opened successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
