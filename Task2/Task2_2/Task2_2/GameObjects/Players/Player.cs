using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.GameInterfaces;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Players
{
    class Player : HasCharacteristics, IMoveable, IControlable
    {
        public int Score
        {
            get;
            set;
        } 

        public int Lives
        {
            get;
            set;
        }

        public override char Symbol => 'g';

        public override ConsoleColor Color => ConsoleColor.Cyan;

        public Player(Vector2 position)
        {
            Name = "Player";
            Position = position;
        }

        public void Control(ConsoleKey consoleKey)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
