using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Exe_13
    {
        //13. Write a C# program that
        //reads a list of URLs from the user and downloads the content of each URL.
        //Handle the exception if any URL is inaccessible.

        //Solution provided in the Exercise solution

        public static void DownloadURL()
        {
            Console.WriteLine("Input the URLs (one URL per line, press Enter to complete):");

            try
            {
                while (true)
                {
                    string url = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(url))
                    {
                        break;
                    }

                    DownloadContent(url);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Error accessing URL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void DownloadContent(string url)
        {
            WebClient webClient = new WebClient();

            string content = webClient.DownloadString(url);

            Console.WriteLine("Content of URL '" + url + "':");
            Console.WriteLine(content);
            Console.WriteLine();
        }
    }
}




