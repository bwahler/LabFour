using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts user for an integer and takes input
            bool program = true;
            while (program == true)
            {
                try
                {
                    Console.WriteLine("Please enter an integer:");
                    int number = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number" + "\t\t" + "Squared" + "\t\t" + "Cubed");
                    Console.WriteLine("======" + "\t\t" + "=======" + "\t\t" + "======");

                    for (int i = 1; i <= number; i++)
                    {
                        //Input is ran through equation for squared and cubed outputs
                        int square = i * i;
                        int cube = i * i * i;
                        Console.WriteLine(i + "\t\t" + square + "\t\t" + cube);
                    }
                    program = Continue();
                }
                catch(FormatException)
                {
                    Console.WriteLine("This not an accepted input");
                }
            }
        }

        public static bool Continue()
        {
            //User prompt for continue
            Console.WriteLine("Would you like to continue running the program? (y/n)");
            string usercontinue = Console.ReadLine().ToLower();
            bool run;

            if (usercontinue == "y")
            {
                run = true;
            }
            else if (usercontinue == "n")
            {
                run = false;

            }
            else
            {
                Console.WriteLine("That is an invalid response. Please try again:");
                run = Continue();
            }
            return run;
        }
    }
}
