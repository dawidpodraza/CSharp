using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        private string name;
        private int age;

        public Class1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public  string got() 
        {
            return "Działa";
        }
    }
}

