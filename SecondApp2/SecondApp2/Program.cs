using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecondApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            START:

            Console.WriteLine("Witaj w programie \"Kalkulator\"");

            
            Console.WriteLine("\" dodawanie +\", \"odejmowanie -\", \"mnożenie *\", \"dzielenie /\", \"reszta z dzielenia %\"");

            Console.WriteLine("Podaj 1 liczbę:");
            double number1 = userInput();
            

            Console.WriteLine("Podaj 2 liczbę:");
            double number2 = userInput();

            Console.WriteLine("Wybierz działanie + - * / %:");
            string userChoice = userInput2();

            double? result  = null;

            if(userChoice == "+")
            {
                result = number1 + number2;
            }
            else if(userChoice == "-")
            {
                result = number1 - number2;
            }
            else if (userChoice == "*")
            {
                result = number1 * number2;
            }
            else if (userChoice == "/")
            {
                result = number1 / number2;
            }else if (userChoice == "%")
            {
                result = number1 % number2;
            }
            else
            {
                Console.WriteLine("Podano błędne działanie");
            }

            Console.WriteLine("Wynik: "+ result);

            Console.WriteLine("Czy chcesz zakończyć program? y/n");
            userChoice = userInput2();
            if (userChoice =="y") {
                Console.Clear();
            }
            else
            {
                goto START;
            }
        }

        public static double  userInput() 
        { 
          return double.Parse(Console.ReadLine());
        }

        public static string userInput2()
        {
            return Console.ReadLine();
        }
    }
}
