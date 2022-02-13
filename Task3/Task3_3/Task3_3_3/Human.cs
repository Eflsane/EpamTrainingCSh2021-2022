using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_3
{
    class Human
    {
        public string MakeOrder(PizzasHome pizzasHome, PizzasType pizzasType)
        {
            Order order = pizzasHome.MakeOrder(pizzasType);
            order.OnReady += Order_Onready;

            return $"{order.Number} is in cooking process";
        }

        private string Order_Onready(Order sender, string pizzaName)
        {
            sender.OnReady -= Order_Onready;
            Console.WriteLine($"Order {sender.Number} {pizzaName} is ready and taken");

            return $"Order {sender.Number} {pizzaName} is ready and taken";
        }
    }
}
