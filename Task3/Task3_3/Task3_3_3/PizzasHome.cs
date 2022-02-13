using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_3
{
    class PizzasHome
    {
        List<Order> _orders;

        public PizzasHome()
        {
            _orders = new List<Order>();
        }

        public Order MakeOrder(PizzasType pizzasType)
        {
            Order order = new Order(pizzasType);
            _orders.Add(order);
            return order;
        }
    }
}
