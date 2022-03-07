using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Bonuses
{
    class Whiskey : Bonus
    {
        public override int BonusPower => 10;

        public override char Symbol => 'W';

        public override ConsoleColor Color => ConsoleColor.Green;

        public Whiskey(Vector2 position)
        {
            Name = "Whiskey";
            Position = position;
        }

        public override void UseBonus(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
