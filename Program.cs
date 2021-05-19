/*
 * Thank you for viewing my first program!
 *
 * I have never programmed prior so this is all very new to me.
 * If you see anything that could make my calculator better, please do not hesitate with your suggestions!
 * 
 * Kind regards, Oscar.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal firstNum;
            decimal secondNum;
            string operation;
            decimal answer;
            string Userchoice;


            do //User choice of whether to run or exit the program 
            {
                Console.WriteLine("\n\n\n\n\t\t\t\t\tPress 'M' followed by 'Enter' to run \n\n\t\t\t\t\tOr press 'A' followed by 'Enter' to exit");
                Userchoice = Console.ReadLine();
                Userchoice = Userchoice.ToUpper();
                Console.Clear();
                if (Userchoice == "M") //Runs calculator
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\t\t\t\t     Hello and welcome to my first simple calculator!");
                    Console.WriteLine("\n\n\t\t\t\t\t ------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\t\t\t\t   Press 'Enter' to get started.");
                    Console.ReadLine();

                    Console.Clear();

                    Console.Write("Enter the first number in your basic equation: ");
                    firstNum = Convert.ToDecimal(Console.ReadLine());

                    //User input for equation
                    Console.Write("Enter the second number in your basic equation: ");
                    secondNum = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\n\t\t__________________________________________________________________________________________");
                    Console.Write("\n\t\t          Input your type of subject for your equation -> ( x , / , +, -) ");
                    operation = Console.ReadLine();

                    if (operation == "x")
                    {
                        answer = firstNum * secondNum;
                        Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else if (operation == "/")
                    {
                        answer = firstNum / secondNum;
                        Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    //Getting answers
                    else if (operation == "+")
                    {
                        answer = firstNum + secondNum;
                        Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else if (operation == "-")
                    {
                        answer = firstNum - secondNum;
                        Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                        Console.ReadLine();


                    }
                }
                else if (Userchoice == "A")
                {
                    Console.WriteLine("Du har valgt afslutning af programmet... FARVEL!");
                    System.Environment.Exit(0);

                }

            } while (Userchoice != "A"); //The calculator is running if the user pressed 'M'

            Console.ReadKey();
        }
    }
}