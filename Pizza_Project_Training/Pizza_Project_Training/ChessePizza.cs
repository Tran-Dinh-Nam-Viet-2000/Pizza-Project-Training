using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project_Training
{
    public class ChessePizza : Pizza
    {
        public ChessePizza()
        {
            name = "Chesse Pizza";
            dough = "Thin";
            sauce = "Spicy sauce";
            toppings.Add("Vegetable");
            toppings.Add("Chesse");
        }
    }
}
