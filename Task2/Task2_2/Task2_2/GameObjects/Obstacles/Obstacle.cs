using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Obstacles
{
    class Obstacle : HasCharacteristics
    {
        private char symbol;
        public override char Symbol => symbol;

        public override ConsoleColor Color => ConsoleColor.DarkYellow;

        public Obstacle(string name, Characteristics characteristics, char symbol, Vector2 position)
        {
            this.Name = name;
            Characteristics = characteristics;
            this.symbol = symbol;
            Position = position;
        }
    }
}
