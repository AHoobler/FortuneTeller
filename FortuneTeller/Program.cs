using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare all variables in main

            //  part one

            Console.WriteLine("Please tell me your first name");
            string fName = Console.ReadLine().ToUpper();



            Console.WriteLine("Please tell me your last name");
            string lName = Console.ReadLine().ToUpper();



            Console.WriteLine("Please tell me your age");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Please tell me the month you were born");
            int bMonth = int.Parse(Console.ReadLine()); //store as integer


            Console.WriteLine("Please tell me your favorite ROYGBIV color, or ask for help");
            string favColor = Console.ReadLine().ToUpper();     




            // Must provide help menu listing the ROYGBIV colors
            // string roygbiv = "";


            switch (favColor)

            {
                case "HELP":
                    Console.WriteLine();
                    Console.WriteLine("Please choose a color from the following options:");
                    Console.WriteLine("Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet");
                    Console.WriteLine();
                    break;
            }


            //only needs to be asked if they ask for help
            Console.WriteLine("Please choose a color from the list above");
            string roygbiv = Console.ReadLine();

            // mode of transportation for ROYGBIV
            // need to store, not print. need an if statement 

            

            Console.WriteLine("Please tell me the number of siblings you have");
            int siblings = int.Parse(Console.ReadLine()); //store as integer


            // Part 2

            // calculate years until retirement based on age. Based on even or odd years

            Console.Write( fName + lName + "will retire in ");

            int bYear = 2018 - age; // year born based on age
            //Console.WriteLine(bYear);
            int evenOdd = bYear % 2; // 1 odd year, 0 even year
            //Console.WriteLine(evenOdd);
            
            if (evenOdd == 1)
            {
                Console.Write(" 30 years ");
            }

            if (evenOdd == 0) //int to bool = no 
            {
                Console.Write(" 1 year ");
            }



            Console.Write(" with ");
            // Money in the bank based on birth months. 1-4, 5-8, 9-12, 0 for -1 & +12
            //if else

            if ((bMonth <= 4) && (bMonth >= 1))
            {
                Console.Write("$100.00");
            }
            if ((bMonth <= 0) || (bMonth > 12))
            {
                Console.Write("$0.00");
            }
            if ((bMonth <= 8) && (bMonth >= 5))
            {
                Console.Write("$1000.00");
            }
            if ((bMonth <= 12) && (bMonth >= 9))
            {
                Console.Write("$10000.00");
            }


            Console.Write(" in the bank, a vacation home ");
                // choose vacation home based on number of siblings, 3+, -0, 0, 1, 2 ,3 
                // if else

            if (siblings <= 0)
            {
                Console.Write("on the island from 'Lost '");

            }

            if (siblings == 0)
            {
                Console.Write("in Rio, Brazil ");
            }
            
            if (siblings == 1)
            {
                Console.Write("in Scranton, PA ");
            }

            if (siblings == 2)
            {
                Console.Write("in Geneva, Switzerland ");
            }

            if (siblings == 3)
            {
                Console.Write("in Los Angeles, CA ");
            }

            if (siblings > 3)
            {
                Console.Write("in Sydney, Australia ");
            }

            Console.Write(" and a ");

            switch (roygbiv)
            {
                case "red":
                    Console.Write("pogo stick ");
                    break;

                case "orange":
                    Console.Write("submarine ");
                    break;

                case "yellow":
                    Console.Write("river boat ");
                    break;

                case "green":
                    Console.Write("batmobile ");
                    break;

                case "blue":
                    Console.Write("space shuttle ");
                    break;

                case "indigo":
                    Console.Write("hang glider ");
                    break;

                case "violet":
                    Console.Write("raft ");
                    break;
            }

            Console.WriteLine("");
            //part three

            // The application MUST display the user’s fortune in the following format:
            // [First Name][Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].


        }
    }
}
