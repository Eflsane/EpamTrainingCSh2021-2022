using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.Positions;

namespace Task2_2.GameObjects
{
    abstract class GameObject
    {
        private Vector2 position;
        public Vector2 Position
        {
            get => position;
            set
            {
                if (value.X < 0 || value.Y < 0)
                    throw new ArgumentOutOfRangeException("position coordinates must be more than -1");

                position = value;
            }
        }

        private string name = "GameObject";
        public  string Name
        {
            get => name;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("name can't be empty string");
                name = value;
            }
        }

        public abstract char Symbol
        {
            get;
        }

        public abstract ConsoleColor Color
        {
            get;
        }
    }
}
