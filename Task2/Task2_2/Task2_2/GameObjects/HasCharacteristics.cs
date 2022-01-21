using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2.GameObjects
{
    abstract class HasCharacteristics : GameObject
    {
        private Characteristics characteristics;
        public Characteristics Characteristics
        {
            get => characteristics;
            set
            {
                if (value.Height <= 0 || value.Strengh <= 0 || value.Speed <= 0)
                    throw new ArgumentException("Height, Strengh and Speed can't be less than or equals 0");
                characteristics = value;
            }
        }
    }
}
