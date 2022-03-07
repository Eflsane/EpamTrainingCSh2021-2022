using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2.GameObjects
{
    struct Characteristics
    {
        public int Strengh
        {
            get;
            private set;
        }

        public int Height
        {
            get;
            private set;
        }

        public int Speed
        {
            get;
            private set;
        }

        public Characteristics(int strengh, int height, int speed)
        {
            Strengh = strengh;
            Height = height;
            Speed = speed;
        }
    }
}
