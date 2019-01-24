/*
    Author: Monica Costa
    Date: 1/24/2019
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1-100: ");

            try
            {
                //This variable will gather data from user input
                string input = Console.ReadLine();

                //This variable will be used to perform the various iterative statements and is parsed as int
                int value_of_input = int.Parse(input);

               
                // Here is the For Loop
                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine("You have entered " + i.ToString() + " This is the current integer value in the loop:");
                }

                Console.WriteLine("Press any key to exit");
                // Pause the program and wait for the user to press a key and end the program
                Console.ReadKey(true);

            } //End of try

            catch
            {
                Console.WriteLine("There was an error");
                Console.ReadKey(true);
            } //End of catch
        }
    }
}
