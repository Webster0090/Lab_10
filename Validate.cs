using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validate
    {
        public static bool YesOrNo(string response)
        {

            while (true)
            {

                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("Invalid input, try (y/n): ");
                    response = Console.ReadLine().ToLower();

                }
            }

        }
        public static double ValidateRadius()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please enter the radius of a circle: ");
                    double num = double.Parse(Console.ReadLine());
                    return num;

                }
                catch (FormatException)
                {
                    Console.Write("You have a entered an invalid format. Please enter a valid number: ");
                }
            }
        }
    }
}
