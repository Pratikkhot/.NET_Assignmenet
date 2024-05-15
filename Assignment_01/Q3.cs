using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment_1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double res;

            int choice;

            do
            {
           
                Console.WriteLine("Enter your operation: ");
                Console.WriteLine("1} Addition ");
                Console.WriteLine("2} Substraction ");
                Console.WriteLine("3} Multiplication ");
                Console.WriteLine("4} Division ");
                Console.WriteLine("0} Exit ");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter first number: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {

                    case 0: Console.WriteLine("Exiting.... ");
                        break;

                    case 1:
                        res = a + b;
                        Console.WriteLine("Addition: " + res);
                        break;

                    case 2:
                        res = a - b;
                        Console.WriteLine("Substraction: " + res);
                        break;

                    case 3:
                        res = a * b;
                        Console.WriteLine("Multiplication: " + res);
                        break;

                    case 4:
                        res = a / b;
                        Console.WriteLine("Division: " + res);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            } while (choice!=0);
        }
    }
}
