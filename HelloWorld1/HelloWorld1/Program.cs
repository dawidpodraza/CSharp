using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car;



namespace HelloWorld1
    
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            SuperCar car1 = new SuperCar("audi", 2009);
            car1.jedz();

        }
    }
}

namespace Car
{
    public class SuperCar
    {
        private String name;
        private int year;

        public SuperCar(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void jedz()
        {
            Console.WriteLine("Jade sobie");
        }
    }

}
