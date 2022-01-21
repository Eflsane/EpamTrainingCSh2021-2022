using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Enemies
{
    class Troll : Enemy
    {
        public override char Symbol => 'T';

        public override ConsoleColor Color => ConsoleColor.Red;

        public Troll(Vector2 position)
        {
            Name = "Troll";
            Position = position;
        }

        public override void Attack(Player player)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
