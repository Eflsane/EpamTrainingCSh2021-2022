using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Bonuses
{
    class Beer : Bonus
    {
        public override int BonusPower => 1;

        public override char Symbol => 'B';

        public override ConsoleColor Color => ConsoleColor.DarkGreen;

        public Beer(Vector2 position)
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
