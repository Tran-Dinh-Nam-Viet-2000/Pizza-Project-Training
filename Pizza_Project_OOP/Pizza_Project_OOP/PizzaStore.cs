using Pizza_Project_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project_Training
{
    public class PizzaStore
    {
        public void OrderPizza1()
        {
            var chessePizza = new ChessePizza();
            chessePizza.Prepare();
            chessePizza.Bake();
            chessePizza.Cut();
            chessePizza.Box();
        }
        public void OrderPizza2()
        {
            var eggPizza = new EggPizza();
            eggPizza.Prepare();
            eggPizza.Bake();
            eggPizza.Cut();
            eggPizza.Box();
        }
    }
}
