using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
         class BaskinRobbins : IceCreamShop // derived class
        {
            public string IcecreamType { get; set; }
            public string Toppings { get; set; }

        public BaskinRobbins () 
        {

        }

        public BaskinRobbins(string icecreamtype, string toppings, string icecreamFlavors, string icecreamContainer) : base (icecreamFlavors, icecreamContainer) // insert strings from base class 
        {
            this.IcecreamType = icecreamtype; // the icecream above equals the string
            this.Toppings = toppings; // toppings above equals string
        }

        public void Order2 () // method for baskin robbins 

        {
            Console.WriteLine($"Customer 2 ordered {IcecreamType} {IcecreamFlavors} ice cream in a {IcecreamContainer} with {Toppings}");
        }
        }

    }

