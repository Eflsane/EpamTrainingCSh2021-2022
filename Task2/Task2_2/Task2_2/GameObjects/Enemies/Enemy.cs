using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.GameInterfaces;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Enemies
{
    abstract class Enemy : HasCharacteristics, IMoveable
    {
        public abstract void Attack(Player player);
        public abstract void Move();
    }
}
