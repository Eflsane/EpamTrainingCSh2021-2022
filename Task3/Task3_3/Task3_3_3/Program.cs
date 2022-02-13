using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzasHome pizzasHome = new PizzasHome();
            Human human = new Human();
            Console.WriteLine(human.MakeOrder(pizzasHome, PizzasType.Peperoni));
            Human h1 = new Human();
            Console.WriteLine(h1.MakeOrder(pizzasHome, PizzasType.Italian));

            Console.ReadKey();
        }
    }
}
