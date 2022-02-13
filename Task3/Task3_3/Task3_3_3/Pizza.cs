using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Task3_3_3
{
    class Pizza
    {

        public event Action<string> OnReady = (string pizzaName) => { };

        public Pizza()
        {
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromSeconds(2).TotalMilliseconds);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        public Pizza(string name) : this()
        {
            Name = name;
        }

        public string Name { get; private set; }

        public string Cook()
        {
            Thread.Sleep((int)TimeSpan.FromSeconds(4).TotalMilliseconds);
            return Name;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnReady(Cook());
        }

    }

    public enum PizzasType
    {
        Null = 0,
        Peperoni = 1,
        Italian = 2,
    } 
}
