using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count = 1;
            while (true)
            {
                
                Console.WriteLine("Welcome to the Circle Tester!");
                Console.Write("Please enter the radius of the circle: ");
                double userInput = double.Parse(Console.ReadLine());

                Circle myCircle = new Circle(userInput);
                Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}");
                Console.WriteLine($"Circumference Formatted! {myCircle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {myCircle.CalculateArea()}");
                Console.WriteLine($"Area Formatted! {myCircle.CalculateFormattedArea()}");
                
                Console.WriteLine("Would you like to continue? (y/n)");

                input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    count++;
                }
                else if (input == "n")
                {
                    break;
                }


            }
        }
    }
}


