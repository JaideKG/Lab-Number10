using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number10
{
    class Program
    {
        static void Main(string[] args)
        {
             
            

            //Welcome statement
            //Prompt user to enter a radius
            Console.WriteLine("Would you like to know the radius of a circle?");
            bool Repeat = true;
            string response = "";
            int count = 0;
            while (Repeat)
            {
                count++;
                double r;
                Console.WriteLine("Please enter a radius.");
                r = double.Parse(Console.ReadLine());
                Circle MyCircle = new Circle(r);
                string circumference = MyCircle.CalFormCirc();
                string area = MyCircle.CalFormArea();

                Console.WriteLine("The Circumference (C=2πr) of your circle is: {0:F2}", circumference);
                Console.WriteLine("The Area (A=πr2) of your circle is: {0:0.00}", area);

                bool repeatOne = true;
                while (repeatOne)
                {
                    Console.WriteLine("Would you like to enter another radius? (Y/N)");
                    response = Console.ReadLine();
                    if (response.ToLower() == "y")
                    {
                        Repeat = true;
                        repeatOne = false;
                    }
                    else if (response.ToLower() == "n")
                    {
                        repeatOne = false;
                        Repeat = false;
                        Console.WriteLine($"Goodbye. You created {count} Circle object(s)");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you entered an invalid response. Please try again.");
                    }
                }
               
                                    


            }
        }
    }
}