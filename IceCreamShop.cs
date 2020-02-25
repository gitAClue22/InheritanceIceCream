using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class IceCreamShop //base class

    {
        public string IcecreamFlavors { get; set; }
        public string IcecreamContainer { get; set; }
        public IceCreamShop () //default constructor
            {

            }
       
        public IceCreamShop (string icecreamFlavors, string icecreamContainer)
        {
            this.IcecreamFlavors = icecreamFlavors;
            this.IcecreamContainer = icecreamContainer;
        }
        public void CustomerOrder ()
        {
            Console.WriteLine($"Customer 1 ordered {IcecreamFlavors} ice cream in a {IcecreamContainer}.");
        }
       
    }
}
