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

            int firstNum;
            int secondNum;                   //Variables for equation
            string operation;
            int answer;
            string Userchoice;
            

            do //Kører Userchoice variablen for valg om start eller ej af selve programmet.
            {
                Console.WriteLine("Tryk M for at starte lommeregneren \nEller tryk A for at afslutte");
                Userchoice = Console.ReadLine();
                Userchoice = Userchoice.ToUpper();
                if (Userchoice == "M") //Man har accepteret start af lommeregner og funktionen er igang
                {

                    Console.WriteLine("\n\n\t\t\t\t     Hej og velkommen til Oscars første lommeregner.");
                    Console.WriteLine("\n\n\t\t\t\t\t ------------------------------------");
                    Console.WriteLine("\n\n\t\t\t\t\t   Tryk 'Enter' for at komme igang!");
                    Console.ReadLine();

                    Console.Write("Enter the first number in your basic equation: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    //User input for equation
                    Console.Write("Skriv dit første hele tal: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\t\t__________________________________________________________________________________________");
                    Console.Write("\n\t\t          Vælg om du vil gange, dividere, plus eller minus -> ( x , / , +, -) ");
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

            } while (Userchoice != "A");

            Console.ReadKey();
        }
    }
}