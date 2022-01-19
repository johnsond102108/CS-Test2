using System;
using System.Collections.Generic;
using System.Text;

namespace PA1._1
{
    class Cat
    {
        private string name;

        public Cat()
        {
            name = "Steve";
        }

        public Cat(string n)
        {
            name = n;
        }

        public void printCat()
        {
            Console.WriteLine("This cat's name is: " + name);
        }
    }
}
