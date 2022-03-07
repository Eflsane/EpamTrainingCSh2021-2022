using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Bonuses
{
    class Rum : Bonus
    {
        public override int BonusPower => 1;

        public override char Symbol => 'R';

        public override ConsoleColor Color => ConsoleColor.DarkBlue;

        public Rum(Vector2 position)
        {
            Name = "Beer";
            Position = position;
        }

        public override void UseBonus(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
