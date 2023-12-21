using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace FirstProject
{
    

    
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int number = 0;
            int sum = 0;
            int biggest =0;
            int i = 0;

            while(true)
            {
                Console.WriteLine("Podaj liczbę");
                num = int.Parse(Console.ReadLine());

                sum = sum + num;

                if (num > biggest)
                {
                    biggest = num;
                }

                if(num == 0)
                {
                    break;
                }
            }

            Console.WriteLine("Suma wszystkich liczb to: "+ sum );
            Console.WriteLine("Największa liczba to: "+ biggest );
        }
    }
   
}

