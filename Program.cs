using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3 - loop that outputs i*3 from i=10 to i=4000
            int i = 10;
            while (i <= 4000)
            {
                Console.WriteLine("i=" + i);
                i = i * 3;
            }
            //#4 - loop that outputs i/2 from i=12345 to i>1234
            int i = 12345;
            while (i > 1234)
            {
                Console.WriteLine("i/2=" + i / 2);
                i = i - 300;
            }
            // #5 Output a class name depending on input from a user
            Console.WriteLine("Please Enter the course number or 0 to exit: ");
            int courseNum = Convert.ToInt16(Console.ReadLine());
            while (courseNum != 0)
            {
                if (courseNum == 1)
                {
                    Console.WriteLine("Math");
                }
                else if (courseNum == 2)
                {
                    Console.WriteLine("Composition");
                }
                else if (courseNum == 3)
                {
                    Console.WriteLine("History");
                }
                else if (courseNum == 4)
                {
                    Console.WriteLine("Infomation Technology");
                }
                else
                {
                    Console.WriteLine("Invalid Cours Selection.");
                }
                Console.WriteLine("Please Enter the course number: ");
                courseNum = Convert.ToInt16(Console.ReadLine());
            }
            // #6 Output a class name depending on input from a user
            Console.WriteLine("Please Enter the course number or 0 to exit: ");
            int courseNum = Convert.ToInt16(Console.ReadLine());
            while (courseNum != 0)
            {
                switch (courseNum)
                {
                    case 1:
                        Console.WriteLine("Math");
                        break;
                    case 2:
                        Console.WriteLine("Composition");
                        break;
                    case 3:
                        Console.WriteLine("History");
                        break;
                    case 4:
                        Console.WriteLine("Infomation Technology");
                        break;
                    default:
                        Console.WriteLine("Invalid Cours Selection.");
                        break;
                }
                Console.WriteLine("Please Enter the course number or 0 to exit: ");
                courseNum = Convert.ToInt16(Console.ReadLine());
            }


            // #8 An array of values displayed using foreach
            //Initialize the array with the value
            string[] description = { "spicy", "salty", "bland", "greasy", "delicious" };

            //Output the description's name to the console
            foreach (string value in description)
            {
                Console.WriteLine("{0}", value);
            }

        } //End of Main program
    }
}
