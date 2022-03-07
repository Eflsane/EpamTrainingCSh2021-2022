using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.GameInterfaces;
using Task2_2.GameObjects.Players;

namespace Task2_2.GameObjects.Bonuses
{
    abstract class Bonus : HasCharacteristics
    {
        public abstract int BonusPower
        {
            get;
        }

        public abstract void UseBonus(Player player);
    }
}
