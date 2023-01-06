using Pizza_Project_Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project_OOP
{
    public class EggPizza : Pizza
    {
        public EggPizza()
        {
            name = "Egg Pizza";
            dough = "Thick";
            sauce = "So sugar";
            toppings.Add("Sausage");
            toppings.Add("Carrot");
        }
    }
}
