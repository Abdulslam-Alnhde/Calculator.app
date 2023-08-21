using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the calculator .\n");

                while (true)
                {
                    Console.Write("Enter the first Number :");
                    int FirstNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter the secound Sumber :");
                    int SecoundNumber = int.Parse(Console.ReadLine());
                    Console.Write("chose the Kay :");
                    string Kay = Console.ReadLine();


                    switch (Kay)
                    {
                        case "+":
                            Console.WriteLine($"{FirstNumber}+{ SecoundNumber}={ FirstNumber + SecoundNumber}");
                            break;
                        case "-":
                            Console.WriteLine($"{FirstNumber}-{ SecoundNumber}={ FirstNumber - SecoundNumber}");
                            break;
                        case "%":
                            Console.WriteLine($"{FirstNumber}%{SecoundNumber}={FirstNumber % SecoundNumber}");
                            break;
                        case "/":
                            Console.WriteLine($"{FirstNumber}/{SecoundNumber}={FirstNumber / SecoundNumber}");
                            break;
                        case "x":
                            Console.WriteLine($"{FirstNumber}x{SecoundNumber}={FirstNumber * SecoundNumber}");
                            break;
                        default:
                            Console.WriteLine("plese try aghin");
                            break;
                    }
                }

            }
        }
    }
}
