using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cars;


namespace TrainingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2000,"audi");
            Console.WriteLine(car1.jade());


            
        }
    }
}
namespace Cars
{
    public class Car
    {
        private int year;
        private string mark;
        
        public Car(int year, string mark)
        {
            this.year = year;       
            this.mark = mark;

        }

        public string jade()
        {
            return "Jade sobie";
        }
    }
}
