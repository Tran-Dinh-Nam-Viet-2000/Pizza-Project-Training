using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project_Training
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings  = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough: " + dough);
            Console.WriteLine("Adding sauce: " + sauce);
            Console.WriteLine("Adding toppings:");
            toppings.ForEach(topping => Console.WriteLine("\t" + topping));
        }

        public void Bake()
        {
            Console.WriteLine("Baking... " + name + "in 20 minute");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting... " + name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing... " + name);
        }
    }
}
