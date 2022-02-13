using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_3
{
    class Order
    {
        Pizza _pizza;


        public event Func<Order, string, string> OnReady = (Order sender, string pizzaName) => $"Order {sender.Number} {pizzaName} is ready";

        public Order(PizzasType pizzaType)
        {
            _pizza = new Pizza(pizzaType.ToString());
            _pizza.OnReady += _pizza_OnReady;
        }

        public int Number => GetHashCode();

        private String CookPizza()
        {
            return $"Order {Number} {_pizza.Cook()} is ready";
        }

        private void _pizza_OnReady(string pizzaName)
        {
            OnReady(this, pizzaName);
        }
    }
}
