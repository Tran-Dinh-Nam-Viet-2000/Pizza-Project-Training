using System;
using System.Collections.Generic;

namespace Pizza_Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your pizza: ");
            string random = Console.ReadLine();
            var orderPizza = new PizzaStore();
            if (random == "Chesse Pizza")
            {
                
                orderPizza.OrderPizza1();
            }
            if (random == "Egg Pizza")
            {
                orderPizza.OrderPizza2();
            }
        }
    }
}
