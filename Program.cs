using System;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {

            IceCreamShop customer1 = new IceCreamShop ("chocolate" , "cone");
            customer1.CustomerOrder();

            BaskinRobbins customer2 = new BaskinRobbins("soft serve", "sprinkles and pecans", "vanilla", "waffle cone");
            customer2.Order2();

           


        }
    }
}
