using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    internal class Caculator
    {
        static void Main(string[] args)
        {
            int choice;
            int a, b;
            do
            {
                Console.WriteLine("=============CACULATOR===========");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Minus");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Please choice an option above!");

                string input = Console.ReadLine();
                choice = Convert.ToInt32(input);

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("See you later");
                        break;
                    case 1:
                        Console.WriteLine("Enter number a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Total of two number is: " + (a+b));
                        break;
                    case 2:
                        Console.WriteLine("Enter number a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Difference of two number is: " + (a-b));
                        break;
                    case 3:
                        Console.WriteLine("Enter number a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Multiplation of two number is: " + (a*b));
                        break;
                    case 4:
                        Console.WriteLine("Enter number a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b == 0)
                        {
                            Console.WriteLine("Denominator must not be zero number");
                            continue;
                        }
                        Console.WriteLine("Division of two number is: " + (1.0f*a/b));
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
