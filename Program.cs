using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempCheck
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature checker");
            

            double temp;

            while (true)
            {
                try
                {
                    temp = InputDouble("Please enter your temperture (C)");
                    break;

                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            while (true)
            {

                if (temp > 37.0)
                {
                    Console.Write("You have a temperature of ");
                    Console.WriteLine(temp.ToString() + " C");
                    Console.WriteLine("You have a fever, please press any key to exit the program");
                    break;
                }
                else if (temp <= 0)
                {
                    Console.WriteLine("That is not a valid input, please press any key to exit the program");
                    break;
                }
                else if (37.0 > temp)
                {
                    Console.Write("You have a temperature of ");
                    Console.WriteLine(temp.ToString() + " C");
                    Console.WriteLine("You are at risk of hyporthermia, please press any key to exit the program");
                    break;
                }

                else if (temp == 37.0)
                {
                    Console.Write("You have a temperature of ");
                    Console.WriteLine(temp.ToString() + " C");
                    Console.WriteLine("You are not at risk, please press any key to exit the program");
                    break;
                }


                else
                {
                    Console.WriteLine("That is not a valid input, please press any key to exit the program");
                    break;
                }

            }

            Console.ReadKey();
                
        }
        // creates a function for inputting a double
        static double InputDouble(string prompt)
        {
            Console.WriteLine(prompt);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
    }
}
